using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CyclePro.Data
{
    public class Hrm
    {
        public string FileName;
        public HrmParameters Parameters;
        public HrmFeatures Features;
        public List<HrmData> Data;

        public static Hrm PrimaryHrm;
        public static Hrm SecondaryHrm;

        /// <summary>
        /// Add model number and device name to extend functionality.
        /// </summary>
        private static readonly Dictionary<int, string> ModelName = new Dictionary<int, string>
        { 
            // Model Id / Model Name
            {1, "Sport Tester / Vantage XL"},
            {2, "Vantage NV (VNV)"},
            {3, "Accurex Plus"},
            {4, "XTrainer Plus"},    
            {6, "S520"},
            {7, "Coach"},
            {8, "S210"},
            {9, "S410"},
            {10, "S510"},
            {11, "S610 / S610i"},
            {12, "S710 / S710i / S720i"},
            {13, "S810 / S810i"},
            {15, "E600"},
            {20, "AXN500"},
            {21, "AXN700"},
            {22, "S625X / S725X"},
            {23, "S725"},
            {33, "CS400"},
            {34, "CS600X"},
            {35, "CS600"},
            {36, "RS400"},
            {37, "RS800"},
            {38, "RS800X"}
        };

        public Hrm(string text)
        {
            SetParameters(text);
            SetFeatures(Parameters.SMode);
            SetHrmData(text);
        }

        public static string GetHrmParameter(string data, string param)
        {
            var expr = "^" + param + @"=(.*).$";
            var match = Regex.Match(data, expr,
                                      RegexOptions.Multiline | RegexOptions.IgnoreCase);
            if (!match.Success)
                return null;

            var value = match.Groups[1].Value;
            return value;
        }

        public void SetFeatures(string mode)
        {
            switch (mode.Length)
            {
                case 3:
                    Features = new HrmFeatures
                    {
                        Cadence = mode[0] == '0',
                        Altitude = mode[0] == '1',
                        Euro = mode[2] == '0'
                    };
                    break;
                case 8:
                case 9:
                default:
                    Features = new HrmFeatures
                    {
                        Speed = mode[0] == '1',
                        Cadence = mode[1] == '1',
                        Altitude = mode[2] == '1',
                        Power = mode[3] == '1',
                        Euro = mode[7] == '0',
                        Pressure = mode[8] == '1'
                    };
                    break;
            }
        }

        private static DateTime SetDateTime(string date, string time)
        {
            var year = int.Parse(date.Substring(0, 4));
            var month = int.Parse(date.Substring(4, 2));
            var day = int.Parse(date.Substring(6, 2));

            var sTime = time.Split(':');
            var hours = int.Parse(sTime[0]);
            var minutes = int.Parse(sTime[1]);
            var seconds = int.Parse(sTime[2].Substring(0, 2));

            var sDateTime = new DateTime(year, month, day, hours, minutes, seconds);

            return sDateTime;
        }

        private void SetParameters(string text)
        {
            Parameters = new HrmParameters
            {
                // Primary Parameters
                Version = GetHrmParameter(text, "Version"),
                Monitor = ModelName[int.Parse(GetHrmParameter(text, "Monitor"))],
                SMode = GetHrmParameter(text, "SMode"),
                StartDateTime = SetDateTime(GetHrmParameter(text, "Date"), GetHrmParameter(text, "StartTime")),
                Length = GetHrmParameter(text, "Length"),
                Interval = TimeSpan.FromSeconds(double.Parse(GetHrmParameter(text, "Interval"))),

                // Secondary Parameters
                Upper1 = GetHrmParameter(text, "Upper1"),
                Lower1 = GetHrmParameter(text, "Lower1"),
                Upper2 = GetHrmParameter(text, "Upper2"),
                Lower2 = GetHrmParameter(text, "Lower2"),
                Upper3 = GetHrmParameter(text, "Upper3"),
                Lower3 = GetHrmParameter(text, "Lower3"),
                Timer1 = GetHrmParameter(text, "Timer1"),
                Timer2 = GetHrmParameter(text, "Timer2"),
                Timer3 = GetHrmParameter(text, "Timer3"),
                ActiveLimit = GetHrmParameter(text, "ActiveLimit"),
                MaxHr = GetHrmParameter(text, "MaxHR"),
                RestHr = GetHrmParameter(text, "RestHR"),
                StartDelay = GetHrmParameter(text, "StartDelay"),
                Vo2Max = GetHrmParameter(text, "VO2max"),
                Weight = GetHrmParameter(text, "Weight")
            };
        }


        /// <summary>
        /// Calculate the average of a given data parameter
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public double GetAverage(string param)
        {
            double total;
            switch (param)
            {
                case "speed":
                    total = Data.Sum(row => row.Speed);
                    break;
                case "cadence":
                    total = Data.Sum(row => row.Cadence);
                    break;
                case "altitude":
                    total = Data.Sum(row => row.Altitude);
                    break;
                case "power":
                    total = Data.Sum(row => row.Power);
                    break;
                case "pressure":
                    total = Data.Sum(row => row.Pressure);
                    break;
                case "hr":
                    total = Data.Sum(row => row.Hr);
                    break;
                case "distance":
                    total = Data.Sum(row => row.Distance);
                    break;
                default:
                    total = 1.0;
                    break;
            }
            var average = total / Data.Count;
            return average;
        }

        private void SetHrmData(string data)
        {
            const string startString = "[HRData]\r\n";

            var startIndex = data.IndexOf(startString, StringComparison.Ordinal) + startString.Length;
            var rows = data.Substring(startIndex).Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            double totalDistance = 0;

            Data = new List<HrmData>();


            for (var i = 0; i <= rows.Length - 10; i++)
            {
                var r = rows[i].Split('\t');
                var split = Parameters.Interval + TimeSpan.FromSeconds(double.Parse(i.ToString()));
                var stamp = Parameters.StartDateTime + split;

                var row = new HrmData
                {
                    Speed = 0,
                    Cadence = 0,
                    Altitude = 0,
                    Power = 0,
                    Pressure = 0,
                    Hr = double.Parse(r[0]),
                    DateTime = stamp
                };

                if (Features.Speed)
                {
                    double speed;
                    if (Features.Euro)
                    {
                        speed = (double.Parse(r[1]) / 10);
                    }
                    else
                    {
                        speed = (double.Parse(r[1]) / (60 * 60 / 1000));
                    }

                    row.Speed = speed;

                    var seconds = Parameters.Interval.TotalSeconds / 100;

                    var distanceInterval = double.Parse((seconds * speed).ToString(CultureInfo.InvariantCulture));

                    row.Distance = distanceInterval;
                    totalDistance = totalDistance + distanceInterval;
                    row.TotalDistance = totalDistance;
                }

                if (Features.Cadence)
                    row.Cadence = double.Parse(r[2]);
                if (Features.Altitude)
                    row.Altitude = double.Parse(r[3]);
                if (Features.Power)
                    row.Power = double.Parse(r[4]);
                if (Features.Pressure)
                    row.Pressure = double.Parse(r[5]);

                Data.Add(row);
            }
        }
    }
}