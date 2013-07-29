using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam486.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Typography()
        {
            return View();
        }

        public ActionResult UiElements()
        {
            return View();
        }

        public ActionResult Buttons()
        {
            return View();
        }

        public ActionResult Treeview()
        {
            return View();
        }

        public ActionResult Tables()
        {
            return View();
        }

        public ActionResult FormElements()
        {
            return View();
        }

        public ActionResult WizardValidation()
        {
            return View();
        }

        public ActionResult Editors()
        {
            return View();
        }

        public ActionResult Widgets()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult PriceTables()
        {
            return View();
        }

        public ActionResult ForceError500()
        {
            throw new Exception();
        }
    }
}
