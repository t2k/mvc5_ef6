using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KYC.EntitiesScratch;

namespace KYC.Web.Controllers
{
    public class riskClassController : Controller
    {
        private Model1 db = new Model1();

        // GET: riskClass
        public async Task<ActionResult> Index()
        {
            return View(await db.kyc_riskClass.ToListAsync());
        }

        // GET: riskClass/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kyc_riskClass kyc_riskClass = await db.kyc_riskClass.FindAsync(id);
            if (kyc_riskClass == null)
            {
                return HttpNotFound();
            }
            return View(kyc_riskClass);
        }

        // GET: riskClass/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: riskClass/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Class,Score,Ordinal")] kyc_riskClass kyc_riskClass)
        {
            if (ModelState.IsValid)
            {
                db.kyc_riskClass.Add(kyc_riskClass);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(kyc_riskClass);
        }

        // GET: riskClass/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kyc_riskClass kyc_riskClass = await db.kyc_riskClass.FindAsync(id);
            if (kyc_riskClass == null)
            {
                return HttpNotFound();
            }
            return View(kyc_riskClass);
        }

        // POST: riskClass/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Class,Score,Ordinal")] kyc_riskClass kyc_riskClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kyc_riskClass).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(kyc_riskClass);
        }

        // GET: riskClass/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kyc_riskClass kyc_riskClass = await db.kyc_riskClass.FindAsync(id);
            if (kyc_riskClass == null)
            {
                return HttpNotFound();
            }
            return View(kyc_riskClass);
        }

        // POST: riskClass/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            kyc_riskClass kyc_riskClass = await db.kyc_riskClass.FindAsync(id);
            db.kyc_riskClass.Remove(kyc_riskClass);
            await db.SaveChangesAsync();
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
