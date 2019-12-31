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

        public ActionResult WMTSTianDiTu()
        {
            return View();
        }

        public ActionResult AirQualityCityHourData()
        {
            return View();
        }

        public ActionResult Overlay()
        {
            return View();
        }

        public ActionResult Popup()
        {
            return View();
        }

        public ActionResult Icon()
        {
            return View();
        }
        #endregion
        #region TianDiTu
        public ActionResult TianDiTu()
        {
            return View();
        }
        #endregion
    }
}