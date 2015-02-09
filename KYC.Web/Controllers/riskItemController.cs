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
    [Authorize]
    public class riskItemController : Controller
    {
        private Model1 db = new Model1();

        // GET: riskItem
        public async Task<ActionResult> Index()
        {
            var kyc_riskItem = db.kyc_riskItem.Include(k => k.RiskCategory).Include(k => k.RiskClass);
            return View(await kyc_riskItem.ToListAsync());
        }

        // GET: riskItem/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kyc_riskItem kyc_riskItem = await db.kyc_riskItem.FindAsync(id);
            if (kyc_riskItem == null)
            {
                return HttpNotFound();
            }
            return View(kyc_riskItem);
        }

        // GET: riskItem/Create
        public ActionResult Create()
        {
            ViewBag.kyc_riskCategoryId = new SelectList(db.kyc_riskCategory, "Id", "Cateogory");
            ViewBag.kyc_riskClassId = new SelectList(db.kyc_riskClass, "Id", "Class");
            return View();
        }

        // POST: riskItem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Description,kyc_riskCategoryId,kyc_riskClassId,Score,Ordinal")] kyc_riskItem kyc_riskItem)
        {
            if (ModelState.IsValid)
            {
                db.kyc_riskItem.Add(kyc_riskItem);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.kyc_riskCategoryId = new SelectList(db.kyc_riskCategory, "Id", "Cateogory", kyc_riskItem.kyc_riskCategoryId);
            ViewBag.kyc_riskClassId = new SelectList(db.kyc_riskClass, "Id", "Class", kyc_riskItem.kyc_riskClassId);
            return View(kyc_riskItem);
        }

        // GET: riskItem/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kyc_riskItem kyc_riskItem = await db.kyc_riskItem.FindAsync(id);
            if (kyc_riskItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.kyc_riskCategoryId = new SelectList(db.kyc_riskCategory, "Id", "Cateogory", kyc_riskItem.kyc_riskCategoryId);
            ViewBag.kyc_riskClassId = new SelectList(db.kyc_riskClass, "Id", "Class", kyc_riskItem.kyc_riskClassId);
            return View(kyc_riskItem);
        }

        // POST: riskItem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Description,kyc_riskCategoryId,kyc_riskClassId,Score,Ordinal")] kyc_riskItem kyc_riskItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kyc_riskItem).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.kyc_riskCategoryId = new SelectList(db.kyc_riskCategory, "Id", "Cateogory", kyc_riskItem.kyc_riskCategoryId);
            ViewBag.kyc_riskClassId = new SelectList(db.kyc_riskClass, "Id", "Class", kyc_riskItem.kyc_riskClassId);
            return View(kyc_riskItem);
        }

        // GET: riskItem/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kyc_riskItem kyc_riskItem = await db.kyc_riskItem.FindAsync(id);
            if (kyc_riskItem == null)
            {
                return HttpNotFound();
            }
            return View(kyc_riskItem);
        }

        // POST: riskItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            kyc_riskItem kyc_riskItem = await db.kyc_riskItem.FindAsync(id);
            db.kyc_riskItem.Remove(kyc_riskItem);
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
