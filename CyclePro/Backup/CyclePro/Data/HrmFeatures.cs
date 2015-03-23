/****************************** Module Header ******************************\
Module Name:  Software Engineering B
Project:      Cycle Computer Software
Copyright (c) Phillip Jon Marsden. 

All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

namespace CyclePro.Data
{
    /// <summary>
    /// Features define the enabled sensors on the POLAR device
    /// </summary>
    public class HrmFeatures
    {
        public bool Cadence;
        public bool Speed;
        public bool Altitude;
        public bool Power;
        public bool Pressure;
        public bool Hr;
        public bool Euro;

        /// <summary>
        /// Constructor for HRM data features, taking the binary representation for SMode.
        /// </summary>
        /// <param name="mode">string</param>
        public HrmFeatures(string mode)
        {
            switch (mode.Length)
            {
                case 3:
                    Cadence = mode[0] == '0';
                    Altitude = mode[0] == '1';
                    Euro = mode[2] == '0';
                    break;
                case 8:
                case 9:
                default:
                    Speed = mode[0] == '1';
                    Cadence = mode[1] == '1';
                    Altitude = mode[2] == '1';
                    Power = mode[3] == '1';
                    Euro = mode[7] == '0';
                    Pressure = mode[8] == '1';
                    break;
            }
        }
    }
}