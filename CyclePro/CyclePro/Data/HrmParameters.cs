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
using System.Text.RegularExpressions;

namespace CyclePro.Data
{
    public class HrmParameters
    {
        public double Version;
        public string Monitor;
        public string SMode;
        public DateTime StartDateTime;
        public string Length;
        public TimeSpan Interval;
        public int Upper1;
        public int Lower1;
        public int Upper2;
        public int Lower2;
        public int Upper3;
        public int Lower3;
        public TimeSpan Timer1;
        public TimeSpan Timer2;
        public TimeSpan Timer3;
        public int ActiveLimit;
        public int MaxHr;
        public int RestHr;
        public int StartDelay;
        public int Vo2Max;
        public int Weight;

        public HrmParameters(string text)
        {
            // Primary Parameters
            Version =        double.Parse(GetHrmParameter(text, "Version"));
            Monitor =        ModelName[int.Parse(GetHrmParameter(text, "Monitor"))];
            SMode =          GetHrmParameter(text, "SMode");
            StartDateTime =  SetDateTime(GetHrmParameter(text, "Date"), GetHrmParameter(text, "StartTime"));
            Length =         GetHrmParameter(text, "Length");
            Interval =       TimeSpan.FromSeconds(double.Parse(GetHrmParameter(text, "Interval")));

            // Secondary Parameters
            Upper1 = int.Parse(GetHrmParameter(text, "Upper1"));
            Lower1 = int.Parse(GetHrmParameter(text, "Lower1"));
            Upper2 = int.Parse(GetHrmParameter(text, "Upper2"));
            Lower2 = int.Parse(GetHrmParameter(text, "Lower2"));
            Upper3 = int.Parse(GetHrmParameter(text, "Upper3"));
            Lower3 = int.Parse(GetHrmParameter(text, "Lower3"));

            Timer1 = TimeSpan.Parse(GetHrmParameter(text, "Timer1"));
            Timer2 = TimeSpan.Parse(GetHrmParameter(text, "Timer2"));
            Timer3 = TimeSpan.Parse(GetHrmParameter(text, "Timer3"));

            ActiveLimit = int.Parse(GetHrmParameter(text, "ActiveLimit"));
            MaxHr =       int.Parse(GetHrmParameter(text, "MaxHR"));
            RestHr =      int.Parse(GetHrmParameter(text, "RestHR"));
            StartDelay =  int.Parse(GetHrmParameter(text, "StartDelay"));
            Vo2Max =      int.Parse(GetHrmParameter(text, "VO2max"));
            Weight =      int.Parse(GetHrmParameter(text, "Weight"));
        }


        /// <summary>
        /// Get a given parameters average across all hrm data
        /// </summary>
        /// <param name="data">string</param>
        /// <param name="param">string</param>
        /// <returns>string average</returns>
        public string GetHrmParameter(string data, string param)
        {
            var expr = "^" + param + @"=(.*).$";
            var match = Regex.Match(data, expr,
                                      RegexOptions.Multiline | RegexOptions.IgnoreCase);
            if (!match.Success)
                return null;

            var value = match.Groups[1].Value;
            return value;
        }

        /// <summary>
        /// Add model number and device name to extend functionality.
        /// </summary>
        public readonly Dictionary<int, string> ModelName = new Dictionary<int, string>
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

        /// <summary>
        /// Returns a valid DateTime object given the string time and date.
        /// </summary>
        /// <param name="date">string</param>
        /// <param name="time">string</param>
        /// <returns>DateTime date_Time</returns>
        public DateTime SetDateTime(string date, string time)
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
    }
}
