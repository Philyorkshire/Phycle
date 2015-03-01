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
using System.Globalization;
using System.Linq;
using CyclePro.Helper;

namespace CyclePro.Data
{
    /// <summary>
    /// High level class including all parsed parameters from the given file.
    /// </summary>
    public class Hrm
    {
        public HrmParameters Parameters;
        public HrmFeatures Features;
        public List<HrmData> Data;

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
            double totalDistance = 0;

            Data = new List<HrmData>();


            for (var i = 0; i <= rows.Length - 10; i++)
            {
                var r = rows[i].Split('\t');
                var split = Parameters.Interval + TimeSpan.FromSeconds(double.Parse(i.ToString()));
                var stamp = Parameters.StartDateTime + split;
                var n = 0;

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
                    double speed;
                    if (Features.Euro)
                    {
                        speed = (double.Parse(r[n]) / 10);
                    }
                    else
                    {
                        speed = (double.Parse(r[n]) / 3);
                    }

                    row.Speed = speed;

                    var seconds = Parameters.Interval.TotalSeconds / 100;

                    var distanceInterval = double.Parse((seconds * speed).ToString(CultureInfo.InvariantCulture));

                    row.Distance = distanceInterval;
                    totalDistance = totalDistance + distanceInterval;
                    row.TotalDistance = totalDistance;
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
                }

                if (Features.Pressure)
                {
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
    }
}