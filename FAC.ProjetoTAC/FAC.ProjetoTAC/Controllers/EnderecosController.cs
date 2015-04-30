using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fabio.ProjetoTAC.Models;
using FAC.ProjetoTAC.Models;

namespace FAC.ProjetoTAC.Controllers
{
    public class EnderecosController : Controller
    {
        private ConectDbContext db = new ConectDbContext();

        //
        // GET: /Enderecos/

        public ActionResult Index()
        {
            return View(db.Enderecos.ToList());
        }

        //
        // GET: /Enderecos/Details/5

        public ActionResult Details(int id = 0)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            return View(endereco);
        }

        //
        // GET: /Enderecos/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Enderecos/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                db.Enderecos.Add(endereco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(endereco);
        }

        //
        // GET: /Enderecos/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            return View(endereco);
        }

        //
        // POST: /Enderecos/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(endereco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(endereco);
        }

        //
        // GET: /Enderecos/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            return View(endereco);
        }

        //
        // POST: /Enderecos/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            db.Enderecos.Remove(endereco);
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