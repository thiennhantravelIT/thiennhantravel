using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
namespace thiennhan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

           ViewBag.promotion = TourHelpers.GetListRecentTourPromotions();
           ViewBag.tourtypetrongnuoc = TourHelpers.GetListRecentTourbyType(0);//0 là trong nước 1 là quốc tế 2 là tour gia đình
           ViewBag.tourtypequocte = TourHelpers.GetListRecentTourbyType(1);
           ViewBag.tourtypegiadinh = TourHelpers.GetListRecentTourbyType(2);
           ViewBag.placepout = PlaceHelpers.Getplacepopular();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
