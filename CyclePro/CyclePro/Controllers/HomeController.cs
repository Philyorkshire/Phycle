/****************************** Module Header ******************************\
Module Name:  Software Engineering B
Project:      Cycle Computer Software
Copyright (c) Phillip Jon Marsden. 

All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System.IO;
using System.Web;
using System.Web.Mvc;
using CyclePro.Data;

namespace CyclePro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload(HttpPostedFileBase file)
        {
            // Read bytes from http input stream
            BinaryReader b = new BinaryReader(file.InputStream);
            byte[] binData = b.ReadBytes((int) file.InputStream.Length);
            string data = System.Text.Encoding.UTF8.GetString(binData);

            Hrm.PrimaryHrm = new Hrm(data) { Name = file.FileName };

            return RedirectToAction("Dashboard","Analysis");
        }
    }
}