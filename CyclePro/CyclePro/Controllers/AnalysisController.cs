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
using System.Linq;
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
            var el = model.SelectedElements;

            var list = el.Split(',');

            var orderedList = list
                .Select(int.Parse)
                .ToArray()
                .OrderByDescending(c => c);

            foreach (var i in orderedList)
            {
                try
                {
                    Hrm.PrimaryHrm.Data.RemoveRange(i, 10);
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            return View();
        }

        public ActionResult Raw()
        {
            return View();
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
    }
}