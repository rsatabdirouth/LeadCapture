using LeadCapture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeadCapture.Controllers
{
    public class HomeController : Controller
    {
        private TopMortgageEntities _db = new TopMortgageEntities();
        // GET: Home
        public ActionResult Index()
        {
            CustDetail model = new CustDetail();
            var titleItems = new List<SelectListItem> {
                                       new SelectListItem { Text = "Select.", Value = "1", Selected = true },
                                       new SelectListItem { Text = "Mr.", Value = "2", Selected = true },
                                       new SelectListItem { Text = "Miss.", Value = "3", Selected = true },
                                       new SelectListItem { Text = "Mrs.", Value = "4", Selected = true }};
            ViewBag.TitleItems = titleItems;
            var LookingFor = new List<SelectListItem> {
                                       new SelectListItem { Text = "Select.", Value = "1", Selected = true },
                                       new SelectListItem { Text = "Residential Remortgage", Value = "2", Selected = true },
                                       new SelectListItem { Text = "Residentisl Purchase", Value = "3", Selected = true },
                                       new SelectListItem { Text = "Buy To Let Remortgage", Value = "4", Selected = true },
                                       new SelectListItem { Text = "Buy To Let Purchase", Value = "5", Selected = true },
                                       new SelectListItem { Text = "Others", Value = "6", Selected = true }
                                                       };
            ViewBag.LookingFor = LookingFor;

            var Term = new List<SelectListItem> {
                                       new SelectListItem { Text = "Select.", Value = "1", Selected = true },
                                       new SelectListItem { Text = "5 Year", Value = "2", Selected = true },
                                       new SelectListItem { Text = "6 Year", Value = "3", Selected = true },
                                       new SelectListItem { Text = "7 Year", Value = "4", Selected = true },
                                       new SelectListItem { Text = "8 Year", Value = "5", Selected = true },
                                       new SelectListItem { Text = "9 Year", Value = "6", Selected = true },
                                       new SelectListItem { Text = "10 Year", Value = "7", Selected = true },
                                       new SelectListItem { Text = "11 Year", Value = "8", Selected = true },
                                       new SelectListItem { Text = "12 Year", Value = "10", Selected = true },
                                       new SelectListItem { Text = "13 Year", Value = "11", Selected = true },
                                       new SelectListItem { Text = "14 Year", Value = "12", Selected = true },
                                       new SelectListItem { Text = "15 Year", Value = "13", Selected = true },
                                       new SelectListItem { Text = "16 Year", Value = "14", Selected = true },
                                       new SelectListItem { Text = "17 Year", Value = "15", Selected = true },
                                       new SelectListItem { Text = "18 Year", Value = "16", Selected = true },
                                       new SelectListItem { Text = "19 Year", Value = "17", Selected = true },
                                       new SelectListItem { Text = "20 Year", Value = "18", Selected = true },
                                       new SelectListItem { Text = "21 Year", Value = "19", Selected = true },
                                       new SelectListItem { Text = "22 Year", Value = "20", Selected = true },
                                       new SelectListItem { Text = "23 Year", Value = "21", Selected = true },
                                       new SelectListItem { Text = "24 Year", Value = "22", Selected = true },
                                       new SelectListItem { Text = "26 Year", Value = "23", Selected = true },
                                       new SelectListItem { Text = "27 Year", Value = "24", Selected = true },
                                       new SelectListItem { Text = "28 Year", Value = "25", Selected = true },
                                       new SelectListItem { Text = "29 Year", Value = "26", Selected = true },
                                       new SelectListItem { Text = "30 Year", Value = "27", Selected = true },
                                       new SelectListItem { Text = "31 Year", Value = "28", Selected = true },
                                       new SelectListItem { Text = "32 Year", Value = "29", Selected = true },
                                       new SelectListItem { Text = "33 Year", Value = "30", Selected = true },
                                       new SelectListItem { Text = "34 Year", Value = "31", Selected = true },
                                       new SelectListItem { Text = "35 Year", Value = "32", Selected = true },
                                       new SelectListItem { Text = "36 Year", Value = "33", Selected = true },
                                       new SelectListItem { Text = "37 Year", Value = "34", Selected = true },
                                       new SelectListItem { Text = "38 Year", Value = "35", Selected = true },
                                       new SelectListItem { Text = "39 Year", Value = "36", Selected = true },
                                       new SelectListItem { Text = "40 Year", Value = "37", Selected = true } };
                  ViewBag.Term = Term;


            var RateType = new List<SelectListItem> {
                                       new SelectListItem { Text = "Select", Value = "1", Selected = true },
                                       new SelectListItem { Text = "Fixed", Value = "2", Selected = true },
                                       new SelectListItem { Text = "Tracker", Value = "3", Selected = true },
                                       new SelectListItem { Text = "Variable", Value = "4", Selected = true },
                                       new SelectListItem { Text = "NotSure", Value = "5", Selected = true }};
        ViewBag.RateType = RateType;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CustDetail model)
        {
            _db.CustDetails.Add(model);
            _db.SaveChanges();


            return RedirectToAction("Index","ThankYou");
        }
    }
}