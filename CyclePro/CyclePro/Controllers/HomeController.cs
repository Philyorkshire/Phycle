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

            Hrm.PrimaryHrm = new Hrm(data);

            return RedirectToAction("Dashboard","Analysis");
        }
    }
}