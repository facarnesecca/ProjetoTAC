using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FAC.ProjetoTAC.Models;

namespace FAC.ProjetoTAC.Controllers
{
    public class EstadosController : Controller
    {
        private ConectDbContext db = new ConectDbContext();

        //
        // GET: /Estados/

        public ActionResult Index()
        {
            return View(db.Estadoes.ToList());
        }

        //
        // GET: /Estados/Details/5

        public ActionResult Details(int id = 0)
        {
            Estado estado = db.Estadoes.Find(id);
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }

        //
        // GET: /Estados/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Estados/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estado estado)
        {
            if (ModelState.IsValid)
            {
                db.Estadoes.Add(estado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estado);
        }

        //
        // GET: /Estados/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Estado estado = db.Estadoes.Find(id);
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }

        //
        // POST: /Estados/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Estado estado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estado);
        }

        //
        // GET: /Estados/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Estado estado = db.Estadoes.Find(id);
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }

        //
        // POST: /Estados/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estado estado = db.Estadoes.Find(id);
            db.Estadoes.Remove(estado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}