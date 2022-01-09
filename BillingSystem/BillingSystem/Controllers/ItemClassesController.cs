using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BillingSystem.Models;

namespace BillingSystem.Controllers
{
    public class ItemClassesController : Controller
    {
        private BillingDetailsEntities db = new BillingDetailsEntities();

        // GET: ItemClasses
        public ActionResult Index()
        {
            return View(db.ItemClass.ToList());
        }

        // GET: ItemClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemClass itemClass = db.ItemClass.Find(id);
            if (itemClass == null)
            {
                return HttpNotFound();
            }
            return View(itemClass);
        }

        // GET: ItemClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemClasses/Create
        // 若要免於大量指派 (overposting) 攻擊，請啟用您要繫結的特定屬性，
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClassId,ClassName")] ItemClass itemClass)
        {
            if (ModelState.IsValid)
            {
                db.ItemClass.Add(itemClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemClass);
        }

        // GET: ItemClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemClass itemClass = db.ItemClass.Find(id);
            if (itemClass == null)
            {
                return HttpNotFound();
            }
            return View(itemClass);
        }

        // POST: ItemClasses/Edit/5
        // 若要免於大量指派 (overposting) 攻擊，請啟用您要繫結的特定屬性，
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClassId,ClassName")] ItemClass itemClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemClass);
        }

        // GET: ItemClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemClass itemClass = db.ItemClass.Find(id);
            if (itemClass == null)
            {
                return HttpNotFound();
            }
            return View(itemClass);
        }

        // POST: ItemClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemClass itemClass = db.ItemClass.Find(id);
            db.ItemClass.Remove(itemClass);
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
