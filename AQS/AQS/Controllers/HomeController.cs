using AQS.DataCenterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AQS.Controllers
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

        public ActionResult GetCityHourData(DateTime timePoint)
        {
            using (DataCenterServiceClient client = new DataCenterServiceClient())
            {
                CityHourData[] data = client.GetCityHourDataListFromHistoryByTime("GDAEIB", "2019!@GD", timePoint);
                data = data.Where(o => o.AQI != "—").ToArray();
                List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
                foreach (CityHourData item in data)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic.Add("AQI", item.AQI);
                    dic.Add("PM2.5", item.PM2_5);
                    dic.Add("PM10", item.PM10);
                    dic.Add("SO2", item.SO2);
                    dic.Add("NO2", item.NO2);
                    dic.Add("CO", item.CO);
                    dic.Add("O3", item.O3);
                    dic.Add("Name", item.Area);
                    list.Add(dic);
                }
                return Json(list, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetCityDayData(DateTime timePoint)
        {
            using (DataCenterServiceClient client = new DataCenterServiceClient())
            {
                CityDayData[] data = client.GetCityDayDataListFromHistoryByTime("GDAEIB", "2019!@GD", timePoint);
                data = data.Where(o => o.AQI != "—").ToArray();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetStationHourData(DateTime timePoint)
        {
            using (DataCenterServiceClient client = new DataCenterServiceClient())
            {
                StationHourData[] data = client.GetStationHourDataListFromHistoryByTime("GDAEIB", "2019!@GD", timePoint);
                data = data.Where(o => o.AQI != "—").ToArray();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }
    }
}