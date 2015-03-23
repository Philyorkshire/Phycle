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

namespace CyclePro.Data
{
    /// <summary>
    /// HrmData defines the data rows within the POLAR sensor file.
    /// </summary>
    public class HrmData
    {
        public double Hr;
        public double Speed;
        public double Cadence;
        public double Altitude;
        public double Power;
        public double Pressure;
        public DateTime DateTime;
        public double Distance;
        public double TotalDistance;
    }
}
