/****************************** Module Header ******************************\
Module Name:  Software Engineering B
Project:      Cycle Computer Software
Copyright (c) Phillip Jon Marsden. 

All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

namespace CyclePro.Models
{
    /// <summary>
    /// Collects the selected elements from the view to be parsed.
    /// </summary>
    public class GraphModel
    {
        /// <summary>
        /// Holds comma separated string of selected items in the graph table.
        /// </summary>
        public string SelectedElementsToRemove { get; set;}
        public string SelectedElementsToInterval { get; set; }
        public string SelectedElementsToCrop { get; set; }
    }
}