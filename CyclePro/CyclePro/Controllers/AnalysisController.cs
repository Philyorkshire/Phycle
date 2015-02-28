using System.Linq;
using System.Web.Mvc;
using CyclePro.Data;
using CyclePro.Models;
using Newtonsoft.Json;

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
                .ToList()
                .OrderByDescending(c => c);
;

            foreach (var i in orderedList)
            {
                if (i < 0 || i >= Hrm.PrimaryHrm.Data.Count)
                {
                    break;
                }
                Hrm.PrimaryHrm.Data.RemoveAt(i);
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

    }
}