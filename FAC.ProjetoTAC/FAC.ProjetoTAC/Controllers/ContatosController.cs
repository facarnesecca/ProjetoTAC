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
    public class ContatosController : Controller
    {
        private ConectDbContext db = new ConectDbContext();

        //
        // GET: /Contatos/

        public ActionResult Index()
        {
            return View(db.Contatos.ToList());
        }

        //
        // GET: /Contatos/Details/5

        public ActionResult Details(int id = 0)
        {
            Contato contato = db.Contatos.Find(id);
            if (contato == null)
            {
                return HttpNotFound();
            }
            return View(contato);
        }

        //
        // GET: /Contatos/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Contatos/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contato contato)
        {
            if (ModelState.IsValid)
            {
                db.Contatos.Add(contato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contato);
        }

        //
        // GET: /Contatos/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Contato contato = db.Contatos.Find(id);
            if (contato == null)
            {
                return HttpNotFound();
            }
            return View(contato);
        }

        //
        // POST: /Contatos/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contato contato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contato);
        }

        //
        // GET: /Contatos/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Contato contato = db.Contatos.Find(id);
            if (contato == null)
            {
                return HttpNotFound();
            }
            return View(contato);
        }

        //
        // POST: /Contatos/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contato contato = db.Contatos.Find(id);
            db.Contatos.Remove(contato);
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