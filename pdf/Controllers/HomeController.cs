using Rotativa.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa.Core.Options;


namespace pdf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ExportarAPDF()
        {


            //string footer = "--footer-center \"Printed on: " + DateTime.Now.Date.ToString("MM/dd/yyyy") + "  Page: [page]/[toPage]\"" + " --footer-line --footer-font-size \"9\" --footer-spacing 6 --footer-font-name \"calibri light\"";

            string cusomtSwitches = string.Format("--header-html  \"{0}\"",
            Url.Action("Footer", "Home", new { area = "" }, "http"));
            return new Rotativa.MVC.ActionAsPdf("PDF")
            {
                
                RotativaOptions = {
                    PageSize = Size.Letter,
                    PageOrientation = Orientation.Portrait,
                    CustomSwitches=cusomtSwitches,
                    PageMargins = { Left = 20, Right = 20, Top=20 }, // it's in millimeters
                    
                }

            };



        }
        
        public ActionResult Footer()
        {
            return View();
        }
        public ActionResult PDF()
        {
            return View();
        }
        public ActionResult verPdf()
        {
            return View();
        }


    }
}