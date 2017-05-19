using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LeadCapture.Models;

namespace LeadCapture.Controllers
{
    public class CustDetailsController : Controller
    {
        private TopMortgageEntities db = new TopMortgageEntities();

        // GET: CustDetails
        public ActionResult Index()
        {
            return View(db.CustDetails.ToList());
        }

        // GET: CustDetails/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustDetail custDetail = db.CustDetails.Find(id);
            if (custDetail == null)
            {
                return HttpNotFound();
            }
            return View(custDetail);
        }

        // GET: CustDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,FirstName,LastName,MobileNumber,AlternativeNumber,EmailAddress,PostCode,Housenameornumber,LooingFor,ValueOfTheProperty,MorttgageAmount,Term,TypeOfRate,MissedEMI,Id")] CustDetail custDetail)
        {
            if (ModelState.IsValid)
            {
                db.CustDetails.Add(custDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(custDetail);
        }

        // GET: CustDetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustDetail custDetail = db.CustDetails.Find(id);
            if (custDetail == null)
            {
                return HttpNotFound();
            }
            return View(custDetail);
        }

        // POST: CustDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Title,FirstName,LastName,MobileNumber,AlternativeNumber,EmailAddress,PostCode,Housenameornumber,LooingFor,ValueOfTheProperty,MorttgageAmount,Term,TypeOfRate,MissedEMI,Id")] CustDetail custDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(custDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(custDetail);
        }

        // GET: CustDetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustDetail custDetail = db.CustDetails.Find(id);
            if (custDetail == null)
            {
                return HttpNotFound();
            }
            return View(custDetail);
        }

        // POST: CustDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CustDetail custDetail = db.CustDetails.Find(id);
            db.CustDetails.Remove(custDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Chhg()
        {
            return View();
        }

    }
}
