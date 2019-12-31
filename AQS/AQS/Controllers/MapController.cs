using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AQS.Controllers
{
    public class MapController : Controller
    {
        #region OpenLayers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CUACE()
        {
            return View();
        }

        public ActionResult CustomControls()
        {
            return View();
        }
        #endregion
    }
}