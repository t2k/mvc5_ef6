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
    public class riskCategoryController : Controller
    {
        private Model1 db = new Model1();

        // GET: riskCategory
        public async Task<ActionResult> Index()
        {
            return View(await db.kyc_riskCategory.ToListAsync());
        }

        // GET: riskCategory/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kyc_riskCategory kyc_riskCategory = await db.kyc_riskCategory.FindAsync(id);
            if (kyc_riskCategory == null)
            {
                return HttpNotFound();
            }
            return View(kyc_riskCategory);
        }

        // GET: riskCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: riskCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Cateogory,Ordinal")] kyc_riskCategory kyc_riskCategory)
        {
            if (ModelState.IsValid)
            {
                db.kyc_riskCategory.Add(kyc_riskCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(kyc_riskCategory);
        }

        // GET: riskCategory/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kyc_riskCategory kyc_riskCategory = await db.kyc_riskCategory.FindAsync(id);
            if (kyc_riskCategory == null)
            {
                return HttpNotFound();
            }
            return View(kyc_riskCategory);
        }

        // POST: riskCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Cateogory,Ordinal")] kyc_riskCategory kyc_riskCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kyc_riskCategory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(kyc_riskCategory);
        }

        // GET: riskCategory/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kyc_riskCategory kyc_riskCategory = await db.kyc_riskCategory.FindAsync(id);
            if (kyc_riskCategory == null)
            {
                return HttpNotFound();
            }
            return View(kyc_riskCategory);
        }

        // POST: riskCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            kyc_riskCategory kyc_riskCategory = await db.kyc_riskCategory.FindAsync(id);
            db.kyc_riskCategory.Remove(kyc_riskCategory);
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
