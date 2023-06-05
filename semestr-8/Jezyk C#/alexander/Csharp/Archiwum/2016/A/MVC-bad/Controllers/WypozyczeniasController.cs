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
    public class WypozyczeniasController : Controller
    {
        private bazaKsiazka db = new bazaKsiazka();

        // GET: Wypozyczenias
        public ActionResult Index()
        {
            return View(db.wypBaza.ToList());
        }

        // GET: Wypozyczenias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wypozyczenia wypozyczenia = db.wypBaza.Find(id);
            if (wypozyczenia == null)
            {
                return HttpNotFound();
            }
            return View(wypozyczenia);
        }

        // GET: Wypozyczenias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wypozyczenias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "wypozyczeniaId,dataWyp,dataZwr")] Wypozyczenia wypozyczenia)
        {
            if (ModelState.IsValid)
            {
                db.wypBaza.Add(wypozyczenia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wypozyczenia);
        }

        // GET: Wypozyczenias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wypozyczenia wypozyczenia = db.wypBaza.Find(id);
            if (wypozyczenia == null)
            {
                return HttpNotFound();
            }
            return View(wypozyczenia);
        }

        // POST: Wypozyczenias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "wypozyczeniaId,dataWyp,dataZwr")] Wypozyczenia wypozyczenia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wypozyczenia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wypozyczenia);
        }

        // GET: Wypozyczenias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wypozyczenia wypozyczenia = db.wypBaza.Find(id);
            if (wypozyczenia == null)
            {
                return HttpNotFound();
            }
            return View(wypozyczenia);
        }

        // POST: Wypozyczenias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wypozyczenia wypozyczenia = db.wypBaza.Find(id);
            db.wypBaza.Remove(wypozyczenia);
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
