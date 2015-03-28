/****************************** Module Header ******************************\
Module Name:  Software Engineering B
Project:      Cycle Computer Software
Copyright (c) Phillip Jon Marsden. 

All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using CyclePro.Helper;

namespace CyclePro.Data
{
    /// <summary>
    /// High level class including all parsed parameters from the given file.
    /// </summary>
    public class Hrm
    {
        public string Name;
        public HrmParameters Parameters;
        public HrmFeatures Features;
        public List<HrmData> Data; 
        public List<HrmIntervals> HrmIntervals;

        /// <summary>
        /// Two static classes to be loaded for primary observation and comparisons.
        /// </summary>
        public static Hrm PrimaryHrm;
        public static Hrm SecondaryHrm;

        /// <summary>
        /// HRM constructor that takes the all text from the given file.
        /// </summary>
        /// <param name="text"></param>
        public Hrm(string text)
        {
            Parameters = new HrmParameters(text);
            Features = new HrmFeatures(Parameters.SMode);
            SetHrmData(text);

            if (Features.Power)
            {
                FindIntervals();
            }

            //CalculateDistance();
        }

        /// <summary>
        /// Calculate the average of a given data parameter
        /// </summary>
        /// <param name="param"></param>
        /// <returns>double average</returns>
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
            return Math.Round(average, 2);
        }

        /// <summary>
        /// Finds and returns the lowest entry for the given parameter.
        /// </summary>
        /// <param name="param"></param>
        /// <returns>double value</returns>
        public double GetLowest(string param) 
        {
            double value;
            switch (param)
            {
                case "speed":
                    value = Data.Min(s => s.Speed);
                    break;
                case "cadence":
                    value = Data.Min(c => c.Cadence);
                    break;
                case "altitude":
                    value = Data.Min(a => a.Speed);
                    break;
                case "power":
                    value = Data.Min(p => p.Power);
                    break;
                case "pressure":
                    value = Data.Min(p => p.Pressure);
                    break;
                case "hr":
                    value = Data.Min(h => h.Hr);
                    break;
                case "distance":
                    value = Data.Min(d => d.Distance);
                    break;
                default:
                    value = 0;
                    break;
            }
            return value;
        }

        /// <summary>
        /// Finds and returns the highest recorded entry for the given parameter.
        /// </summary>
        /// <param name="param"></param>
        /// <returns>double value</returns>
        public double GetHighest(string param)
        {
            double value;
            switch (param)
            {
                case "speed":
                    value = Data.Max(s => s.Speed);
                    break;
                case "cadence":
                    value = Data.Max(c => c.Cadence);
                    break;
                case "altitude":
                    value = Data.Max(a => a.Speed);
                    break;
                case "power":
                    value = Data.Max(p => p.Power);
                    break;
                case "pressure":
                    value = Data.Max(p => p.Pressure);
                    break;
                case "hr":
                    value = Data.Max(h => h.Hr);
                    break;
                case "distance":
                    value = Data.Max(d => d.Distance);
                    break;
                default:
                    value = 0;
                    break;
            }
            return value;
        }

        /// <summary>
        /// Sets all the data rows from the raw HRM data string.
        /// </summary>
        /// <param name="data"></param>
        public void SetHrmData(string data)
        {
            const string startString = "[HRData]\r\n";

            var startIndex = data.IndexOf(startString, StringComparison.Ordinal) + startString.Length;
            var rows = data.Substring(startIndex).Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            double totalDistance = 0.0;

            Data = new List<HrmData>();

            for (var i = 0; i <= rows.Length - 1; i++)
            {
                var r = rows[i].Split('\t');
                var split = Parameters.Interval + TimeSpan.FromSeconds(double.Parse(i.ToString()));
                var stamp = Parameters.StartDateTime + split;
                var n = 0;

                if(r[0] == "") return;
               
                var row = new HrmData
                {
                    Speed = 0,
                    Cadence = 0,
                    Altitude = 0,
                    Power = 0,
                    Pressure = 0,
                    Hr = double.Parse(r[n]),
                    DateTime = stamp
                };

                n++;

                if (Features.Speed)
                {
                    row.Speed = double.Parse(r[n]);
                    var speed = row.Speed * 0.00027777777777778;

                    if (Features.Euro)
                    {
                        row.Speed = (double.Parse(r[n]) / 10);
                        speed = row.Speed * 0.27777777777778;
                    }

                    var interval = Parameters.Interval.TotalSeconds / 1000;

                    var distanceInterval = interval*speed;
                    row.Distance = distanceInterval;

                    row.TotalDistance = totalDistance + distanceInterval;
                    totalDistance = totalDistance + distanceInterval;
                }

                n++;

                if (Features.Cadence)
                {
                    row.Cadence = double.Parse(r[n]); //2
                    n++;
                }

                if (Features.Altitude)
                {
                    row.Altitude = double.Parse(r[n]); //3
                    n++;
                }

                if (Features.Power)
                {
                    row.Power = double.Parse(r[n]); //4
                    n++;
                    row.Pressure = double.Parse(r[n]); //5
                }

                Data.Add(row);
            }
        }

        /// <summary>
        /// Iterates through the set HRM primary data and converts values between imperial and metric.
        /// </summary>
        public static void SwitchMetric(Hrm hrmObject)
        {
            var data = hrmObject.Data;

            foreach (var row in data)
            {
                if (hrmObject.Features.Euro)
                {
                    row.Distance =      row.Distance.ConvertKilometersToMiles();
                    row.TotalDistance = row.TotalDistance.ConvertKilometersToMiles();
                    row.Speed =         row.Speed.ConvertKilometersToMiles();
                    row.Altitude =      row.Altitude.ConvertMetersToFeet();
                }

                else
                {
                    row.Distance =      row.Distance.ConvertMilesToKilometers();
                    row.TotalDistance = row.TotalDistance.ConvertMilesToKilometers();
                    row.Speed =         row.Speed.ConvertMilesToKilometers();
                    row.Altitude =      row.Altitude.ConvertFeetToMeters();
                }
            }
        }


        /// <summary>
        /// Find interval training in the data by analyzing peaks in the power
        /// </summary>
        public void FindIntervals()
        {
            var positionsInts = new List<int>();

            const double tolerance = 1.4;

            for (var i = 0; i < (Data.Count - 4); i+=3)
            {
                var first = (Data[i].Power + Data[i + 1].Power) + Data[i + 2].Power + Data[i + 3].Power;
                var second = (Data[i + 2].Power + Data[i + 3].Power) + (Data[i + 4].Power + Data[i + 4].Power);

                if ((first * tolerance) < second)
                {
                    positionsInts.Add(i);

                    for (var x = i; x < (Data.Count - 4); x++)
                    {
                        var firstColumn = (Data[x].Power + Data[x + 1].Power) + Data[x + 2].Power + Data[i + 3].Power;
                        var secondColumn = (Data[x + 2].Power + Data[x + 3].Power) + (Data[x + 4].Power + Data[x + 4].Power);

                        if ((firstColumn / tolerance) > secondColumn)
                        {
                            i = x;
                            positionsInts.Add(x + 2);
                            break;
                        }
                    }

                }
            }

            CreateIntervalObjects(positionsInts);
        }

        /// <summary>
        /// Create interval object using the indexes of the start and end of peaks in the power output.
        /// </summary>
        /// <param name="markers"></param>
        public void CreateIntervalObjects(List<int> markers)
        {
            HrmIntervals = new List<HrmIntervals>();

            for (var i = 0; i < markers.Count - 1; i += 2)
            {
                var intervalData = new List<HrmData>();

                for (var x = markers[i]; x < markers[i + 1]; x++)
                {
                    intervalData.Add(Data[x]);
                }

                var interval = new HrmIntervals(intervalData);
                HrmIntervals.Add(interval);
            }

            GetIntervalIndexes();
        }

        /// <summary>
        /// Get a list of index values that match for HrmData which are both in the HrmInterval and HrmData
        /// </summary>
        /// <returns></returns>
        public List<int> GetIntervalIndexes()
        {
            return (from interval in HrmIntervals from i in interval.GetIntervals() select Data.IndexOf(i)).ToList();
        }
    }
}