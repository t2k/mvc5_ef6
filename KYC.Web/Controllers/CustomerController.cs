using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KYC.Entities;
using KYC.Web.DbContexts;
using PagedList;

namespace KYC.Web.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private KYCDb db = new KYCDb();

        // GET: Customer
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;


            var custs = from s in db.CUSTUniversals select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                int custID;
                bool isInt;
                isInt = Int32.TryParse(searchString, out custID);
                if (isInt)
                {
                    custs = custs.Where(s => s.ID.Equals(custID));
                }
                else
                {
                    custs = custs.Where(s => s.FullName.Contains(searchString));
                }
            }

            switch (sortOrder)
            {
                case "name_desc":
                    custs = custs.OrderByDescending(s => s.FullName);
                    break;
                default:
                    custs = custs.OrderBy(s => s.FullName);
                    break;
            }

            int pageSize = 12;
            int pageNumber = (page ?? 1);
            return View(custs.ToPagedList(pageNumber, pageSize));
        }

        // GET: Customer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CUSTUniversal cUSTUniversal = db.CUSTUniversals.Find(id);
            if (cUSTUniversal == null)
            {
                return HttpNotFound();
            }
            return View(cUSTUniversal);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.CUSTs, "ID", "BPRole");
            ViewBag.ID = new SelectList(db.CUSTDetails, "ID", "SName");
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FullName,AcctOpenDate,AcctOpenBy,Owner,EditDate,EditBy,KYCStatus,CreditStatus,CustStatus")] CUSTUniversal cUSTUniversal)
        {
            if (ModelState.IsValid)
            {
                db.CUSTUniversals.Add(cUSTUniversal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.CUSTs, "ID", "BPRole", cUSTUniversal.ID);
            ViewBag.ID = new SelectList(db.CUSTDetails, "ID", "SName", cUSTUniversal.ID);
            return View(cUSTUniversal);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CUSTUniversal cUSTUniversal = db.CUSTUniversals.Find(id);
            if (cUSTUniversal == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.CUSTs, "ID", "BPRole", cUSTUniversal.ID);
            ViewBag.ID = new SelectList(db.CUSTDetails, "ID", "SName", cUSTUniversal.ID);
            return View(cUSTUniversal);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FullName,AcctOpenDate,AcctOpenBy,Owner,EditDate,EditBy,KYCStatus,CreditStatus,CustStatus")] CUSTUniversal cUSTUniversal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cUSTUniversal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.CUSTs, "ID", "BPRole", cUSTUniversal.ID);
            ViewBag.ID = new SelectList(db.CUSTDetails, "ID", "SName", cUSTUniversal.ID);
            return View(cUSTUniversal);
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CUSTUniversal cUSTUniversal = db.CUSTUniversals.Find(id);
            if (cUSTUniversal == null)
            {
                return HttpNotFound();
            }
            return View(cUSTUniversal);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CUSTUniversal cUSTUniversal = db.CUSTUniversals.Find(id);
            db.CUSTUniversals.Remove(cUSTUniversal);
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
    }
}
