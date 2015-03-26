/****************************** Module Header ******************************\
Module Name:  Software Engineering B
Project:      Cycle Computer Software
Copyright (c) Phillip Jon Marsden. 

All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CyclePro.Data;
using CyclePro.Models;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace CyclePro.Controllers
{
    public class AnalysisController : Controller
    {
        //
        // GET: /Analysis/

        public ActionResult Dashboard() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dashboard(GraphModel model)
        {
            var list = model.SelectedElementsToRemove.Split(',');

            var orderedList = list
                .Select(int.Parse)
                .ToArray();

            var start = orderedList.Min();
            var range = orderedList.Max() - start;

            Hrm.PrimaryHrm.Data.RemoveRange(start, range);
            return View();
        }

        public ActionResult Raw()
        {
            return View();
        }

        public ActionResult Comparison()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            // Read bytes from http input stream
            BinaryReader b = new BinaryReader(file.InputStream);
            byte[] binData = b.ReadBytes((int)file.InputStream.Length);
            string data = System.Text.Encoding.UTF8.GetString(binData);

            Hrm.SecondaryHrm = new Hrm(data);
            return RedirectToAction("Comparison", "Analysis");
        }

        public string PrimaryJson()
        {
            var data = JsonConvert.SerializeObject(Hrm.PrimaryHrm, Formatting.None);
            return data;
        }

        public string UnitSwitch(int metric)
        {
            Hrm.SwitchMetric(Hrm.PrimaryHrm);
            Hrm.PrimaryHrm.Features.Euro = metric != 1;
            //Hrm.PrimaryHrm.SetHrmData(Hrm.PrimaryHrm.Raw);
            return "Accepted";
        }

        public ActionResult Intervals()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateIntervals(GraphModel model)
        {
            var markers = new List<int>();

            var list = model.SelectedElementsToInterval.Split(',');
            var orderedList = list
                .Select(int.Parse)
                .ToArray();

            Hrm.PrimaryHrm.HrmIntervals.Clear();

            var add = true;

            for(var i = 0; i < orderedList.Count(); i++)
            {
                if(add) markers.Add(orderedList[i]);

                for (var x = i; x < orderedList.Count() - 1; x++)
                {
                    if (orderedList[i + 1] != (orderedList[i] + 10))
                    {
                        markers.Add(orderedList[i]);
                        add = true;
                        break;
                    }
                    
                    add = false;
                    
                }
            }

            markers.Add(orderedList[orderedList.Count() - 1]);

            Hrm.PrimaryHrm.CreateIntervalObjects(markers);

            return RedirectToAction("Intervals", "Analysis");
        }

        [HttpPost]
        public ActionResult CropHrmData(GraphModel model)
        {
            var fivePercent = (Hrm.PrimaryHrm.Data.Count / 10) / 2;

            var list = model.SelectedElementsToCrop.Split(',');
            var orderedList = list
                .Select(int.Parse)
                .ToArray();

            var first = orderedList.Min();
            var count = Hrm.PrimaryHrm.Data.Count - orderedList.Max();

            Hrm.PrimaryHrm.Data.RemoveRange(orderedList.Max(), count - 1);
            Hrm.PrimaryHrm.Data.RemoveRange(0, first - fivePercent);

            return RedirectToAction("Dashboard", "Analysis");
        }

        public ActionResult DownloadHrmDataFile()
        {
            return RedirectToAction("Dashboard", "Analysis");
        }
    }
}