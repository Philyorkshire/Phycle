using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Physcle
{
    public class Hrm
    {
        public HrmParameters Parameters;
        public HrmFeatures Features;
        public List<HrmData> Data;

        public Hrm(string text)
        {
            SetParameters(text);
            SetFeatures(Parameters.SMode);
            SetHrmData(text);
        }

        public static int GetHrmParameter(string data, string param) 
        {
            var expr = "^" + param + @"=(\d+)\r?$";
            var match = Regex.Match(data, expr,
                                      RegexOptions.Multiline | RegexOptions.IgnoreCase);
            
            return match == null || !match.Success ? default(int) : int.Parse(match.Groups[1].Value);
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

        public void SetParameters(string text)
        {
            Parameters = new HrmParameters
            {
                // Primary Parameters
                Version = GetHrmParameter(text, "Version").ToString(),
                Monitor = GetHrmParameter(text, "Monitor").ToString(),
                SMode = GetHrmParameter(text, "SMode").ToString(),
                Date = GetHrmParameter(text, "Date").ToString(),
                StartTime = GetHrmParameter(text, "StartTime").ToString(),
                Length = GetHrmParameter(text, "Length").ToString(),
                Interval = GetHrmParameter(text, "Interval"),

                // Secondary Parameters
                Upper1 = GetHrmParameter(text, "Upper1").ToString(),
                Lower1 = GetHrmParameter(text, "Lower1").ToString(),
                Upper2 = GetHrmParameter(text, "Upper2").ToString(),
                Lower2 = GetHrmParameter(text, "Lower2").ToString(),
                Upper3 = GetHrmParameter(text, "Upper3").ToString(),
                Lower3 = GetHrmParameter(text, "Lower3").ToString(),

                Timer1 = GetHrmParameter(text, "Timer1").ToString(),
                Timer2 = GetHrmParameter(text, "Timer2").ToString(),
                Timer3 = GetHrmParameter(text, "Timer3").ToString(),

                ActiveLimit = GetHrmParameter(text, "ActiveLimit").ToString(),
                MaxHr = GetHrmParameter(text, "MaxHR").ToString(),
                RestHr = GetHrmParameter(text, "RestHR").ToString(),
                StartDelay = GetHrmParameter(text, "StartDelay").ToString(),
                Vo2Max = GetHrmParameter(text, "V02max").ToString(),
                Weight = GetHrmParameter(text, "Weight").ToString()
            };
        }

        public void SetHrmData(string data)
        {
            const string startString = "[HRData]\r\n";

            var startIndex = data.IndexOf(startString, StringComparison.Ordinal) + startString.Length;
            var rows = data.Substring(startIndex).Split(new string[] {Environment.NewLine}, StringSplitOptions.None);

            Data = new List<HrmData>();

            for(var i = 0; i <= rows.Length - 10; i++)
            {
                var r = rows[i].Split('\t');

                var row = new HrmData
                {
                    Speed = 0,
                    Cadence = 0,
                    Altitude = 0,
                    Power = 0,
                    Pressure = 0,
                };

                if (Features.Speed)
                    row.Speed = float.Parse(r[1]);
                if (Features.Cadence)
                    row.Cadence = float.Parse(r[2]);
                if (Features.Altitude)
                    row.Altitude = float.Parse(r[3]);
                if (Features.Power)
                    row.Power = float.Parse(r[4]);
                if (Features.Pressure)
                    row.Pressure = float.Parse(r[5]);

                Data.Add(row);
            }
        }
    }
}