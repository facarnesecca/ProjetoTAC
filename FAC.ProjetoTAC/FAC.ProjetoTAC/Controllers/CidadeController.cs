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
    public class CidadeController : Controller
    {
        private ConectionDBContext db = new ConectionDBContext();

        //
        // GET: /Cidade/

        public ActionResult Index()
        {
            return View(db.Cidades.ToList());
        }

        //
        // GET: /Cidade/Details/5

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
        // GET: /Cidade/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cidade/Create

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
        // GET: /Cidade/Edit/5

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
        // POST: /Cidade/Edit/5

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
        // GET: /Cidade/Delete/5

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
        // POST: /Cidade/Delete/5

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