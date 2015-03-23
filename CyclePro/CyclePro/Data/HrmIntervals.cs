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

namespace CyclePro.Data
{
    public class HrmIntervals
    {
        private readonly List<HrmData> _intervals; 

        public HrmIntervals(List<HrmData> data)
        {
            _intervals = data;
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
                    total = _intervals.Sum(row => row.Speed);
                    break;
                case "cadence":
                    total = _intervals.Sum(row => row.Cadence);
                    break;
                case "altitude":
                    total = _intervals.Sum(row => row.Altitude);
                    break;
                case "power":
                    total = _intervals.Sum(row => row.Power);
                    break;
                case "pressure":
                    total = _intervals.Sum(row => row.Pressure);
                    break;
                case "hr":
                    total = _intervals.Sum(row => row.Hr);
                    break;
                case "distance":
                    total = _intervals.Sum(row => row.Distance);
                    break;
                default:
                    total = 1.0;
                    break;
            }
            var average = total / _intervals.Count;
            return Math.Round(average, 2);
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
                    value = _intervals.Max(s => s.Speed);
                    break;
                case "cadence":
                    value = _intervals.Max(c => c.Cadence);
                    break;
                case "altitude":
                    value = _intervals.Max(a => a.Speed);
                    break;
                case "power":
                    value = _intervals.Max(p => p.Power);
                    break;
                case "pressure":
                    value = _intervals.Max(p => p.Pressure);
                    break;
                case "hr":
                    value = _intervals.Max(h => h.Hr);
                    break;
                case "distance":
                    value = _intervals.Max(d => d.Distance);
                    break;
                default:
                    value = 0;
                    break;
            }
            return value;
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
                    value = _intervals.Min(s => s.Speed);
                    break;
                case "cadence":
                    value = _intervals.Min(c => c.Cadence);
                    break;
                case "altitude":
                    value = _intervals.Min(a => a.Speed);
                    break;
                case "power":
                    value = _intervals.Min(p => p.Power);
                    break;
                case "pressure":
                    value = _intervals.Min(p => p.Pressure);
                    break;
                case "hr":
                    value = _intervals.Min(h => h.Hr);
                    break;
                case "distance":
                    value = _intervals.Min(d => d.Distance);
                    break;
                default:
                    value = 0;
                    break;
            }
            return value;
        }

        public int Count()
        {
            return _intervals.Count;
        }

        public double PowerGenerated()
        {
            return _intervals.Sum(row => row.Power);
        }

        public double TotalDistance()
        {
            return _intervals[_intervals.Count - 1].TotalDistance;
        }

        public List<HrmData> GetIntervals()
        {
            return _intervals;
        }
    }
}