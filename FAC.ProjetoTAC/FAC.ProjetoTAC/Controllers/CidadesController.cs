﻿using System;
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
    public class CidadesController : Controller
    {
        private ConectDbContext db = new ConectDbContext();

        //
        // GET: /Cidades/

        public ActionResult Index()
        {
            return View(db.Cidades.ToList());
        }

        //
        // GET: /Cidades/Details/5

        public ActionResult Details(int id = 0)
        {
            Cidade cidade = db.Cidades.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        //
        // GET: /Cidades/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cidades/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Cidades.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cidade);
        }

        //
        // GET: /Cidades/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Cidade cidade = db.Cidades.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        //
        // POST: /Cidades/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cidade);
        }

        //
        // GET: /Cidades/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cidade cidade = db.Cidades.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        //
        // POST: /Cidades/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cidade cidade = db.Cidades.Find(id);
            db.Cidades.Remove(cidade);
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