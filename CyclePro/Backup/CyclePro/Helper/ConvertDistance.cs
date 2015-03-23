/****************************** Module Header ******************************\
Module Name:  Software Engineering B
Project:      Cycle Computer Software
Copyright (c) Phillip Jon Marsden. 

All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/


namespace CyclePro.Helper
{
    /// <summary>
    /// Convert values between imperial and metric.
    /// </summary>
    public static class ConvertDistance
    {
        /// <summary>
        /// Convert miles(mph) into kilometers (kph).
        /// </summary>
        /// <param name="miles"></param>
        /// <returns>double kilometers</returns>
        public static double ConvertMilesToKilometers(this double miles)
        {
            //
            // Multiply by this constant and return the result.
            //
            return miles*1.609344;
        }

        /// <summary>
        /// Convert kilometers (kph) into miles (mph).
        /// </summary>
        /// <param name="speed"></param>
        /// <returns>double miles</returns>
        public static double ConvertKilometersToMiles(this double speed)
        {
            //
            // Multiply by this constant.
            //
            return speed*0.621371192;
        }

        /// <summary>
        /// Convert feet (ft) into meters (m).
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>double meters</returns>
        public static double ConvertFeetToMeters(this double feet)
        {
            //
            // Convert foot to meters
            //
            return feet / 3.2808;
        }

        /// <summary>
        /// Convert meters (m) into feet (ft).
        /// </summary>
        /// <param name="meters"></param>
        /// <returns>double feet</returns>
        public static double ConvertMetersToFeet(this double meters)
        {
            //
            // Convert meters to feet
            //
            return meters*3.2808;
        }
    }
}