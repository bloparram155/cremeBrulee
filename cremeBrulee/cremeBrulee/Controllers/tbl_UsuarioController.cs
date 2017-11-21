using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cremeBrulee;

namespace cremeBrulee.Controllers
{
    public class tbl_UsuarioController : Controller
    {
        private LeonDbEntities db = new LeonDbEntities();

        // GET: tbl_Usuario
        public ActionResult Index()
        {
            return View(db.tbl_Usuario.ToList());
        }

        // GET: tbl_Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Usuario tbl_Usuario = db.tbl_Usuario.Find(id);
            if (tbl_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Usuario);
        }

        // GET: tbl_Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioID,Nombre,Email,Password,TipoUsuario")] tbl_Usuario tbl_Usuario)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Usuario.Add(tbl_Usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Usuario);
        }

        // GET: tbl_Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Usuario tbl_Usuario = db.tbl_Usuario.Find(id);
            if (tbl_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Usuario);
        }

        // POST: tbl_Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioID,Nombre,Email,Password,TipoUsuario")] tbl_Usuario tbl_Usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Usuario);
        }

        // GET: tbl_Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Usuario tbl_Usuario = db.tbl_Usuario.Find(id);
            if (tbl_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Usuario);
        }

        // POST: tbl_Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Usuario tbl_Usuario = db.tbl_Usuario.Find(id);
            db.tbl_Usuario.Remove(tbl_Usuario);
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
