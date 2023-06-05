using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Biblioteka.Models;
using PagedList;

namespace Biblioteka.Controllers
{
    public class ReadersController : Controller
    {
        private ReaderDatabase db = new ReaderDatabase();

       // [HttpPost]
        public ActionResult Index(SearchReader reader, string sortowanie,int? page)
        {
            

                ViewBag.sortByCard = sortowanie == "malCard" ? "malCard" : "rosnCard";
                ViewBag.sortBySurname = sortowanie == "" ? "malSurn" : "";
                var item = from person in db.readers
                              select person;
                switch (sortowanie)
                {
                    case "malCard":
                        item = item.OrderByDescending(s => s.readerId);
                        break;
                    case "malSurn":
                        item = item.OrderByDescending(s => s.surname);
                        break;
                    case "rosnCard":
                        item = item.OrderBy(s => s.readerId);
                        break;
                    default:
                        item = item.OrderBy(s => s.surname);
                        break;
                }
            if (ModelState.IsValid)
            {
                if (reader.searchById != null && reader.searchBySurname != null)
                {
                    item = from _reader in db.readers
                              where _reader.surname.Equals(reader.searchBySurname) &&
                              _reader.readerId.Equals(reader.searchById)
                              select _reader;
                }
                else if (reader.searchBySurname != null)
                {
                    item = from _reader in db.readers
                              where _reader.surname.Equals(reader.searchBySurname)
                              select _reader;
                }
                else
                {
                    item = from _reader in db.readers
                              where _reader.readerId.Equals(reader.searchById)
                              select _reader;
                }

                
            }
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(item.ToPagedList(pageNumber, pageSize));
            
        }

        // GET: Readers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reader reader = db.readers.Find(id);
            if (reader == null)
            {
                return HttpNotFound();
            }
            return View(reader);
        }

        // GET: Readers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Readers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "readerId,name,surname")] Reader reader)
        {
            if (ModelState.IsValid)
            {
                db.readers.Add(reader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reader);
        }

        // GET: Readers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reader reader = db.readers.Find(id);
            if (reader == null)
            {
                return HttpNotFound();
            }
            return View(reader);
        }

        // POST: Readers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "readerId,name,surname")] Reader reader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reader);
        }

        // GET: Readers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reader reader = db.readers.Find(id);
            if (reader == null)
            {
                return HttpNotFound();
            }
            return View(reader);
        }

        // POST: Readers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reader reader = db.readers.Find(id);
            db.readers.Remove(reader);
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
