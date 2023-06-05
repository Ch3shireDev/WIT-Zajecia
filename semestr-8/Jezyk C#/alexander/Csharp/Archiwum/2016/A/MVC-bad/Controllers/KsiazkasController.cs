using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class KsiazkasController : Controller
    {
        private bazaKsiazka db = new bazaKsiazka();

        // GET: Ksiazkas
        public ActionResult Index()
        {
            return View(db.baza.ToList());
        }

        // GET: Ksiazkas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ksiazka ksiazka = db.baza.Find(id);
            if (ksiazka == null)
            {
                return HttpNotFound();
            }
            return View(ksiazka);
        }

        // GET: Ksiazkas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ksiazkas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ksiazkaId,tytul,autor")] Ksiazka ksiazka)
        {
            if (ModelState.IsValid)
            {
                db.baza.Add(ksiazka);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ksiazka);
        }

        // GET: Ksiazkas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ksiazka ksiazka = db.baza.Find(id);
            if (ksiazka == null)
            {
                return HttpNotFound();
            }
            return View(ksiazka);
        }

        // POST: Ksiazkas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ksiazkaId,tytul,autor")] Ksiazka ksiazka)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ksiazka).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ksiazka);
        }

        // GET: Ksiazkas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ksiazka ksiazka = db.baza.Find(id);
            if (ksiazka == null)
            {
                return HttpNotFound();
            }
            return View(ksiazka);
        }

        // POST: Ksiazkas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ksiazka ksiazka = db.baza.Find(id);
            db.baza.Remove(ksiazka);
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
