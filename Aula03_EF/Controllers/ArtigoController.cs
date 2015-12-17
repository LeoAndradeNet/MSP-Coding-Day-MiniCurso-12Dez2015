using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aula03_EF.Contexto;
using Aula03_EF.Models;

namespace Aula03_EF.Controllers
{
    public class ArtigoController : Controller
    {
        private AulaContext db = new AulaContext();

        // GET: Artigo
        public ActionResult Index()
        {
            var teste = db.Artigos.ToList();

            var artigo = new Artigo();
            artigo.Id = 2;
            artigo.Titulo = "Hakerzão";
            artigo.Autor = "Wesley";
            artigo.Descricao = "Bla Bla";

            db.Artigos.Add(artigo);
            db.SaveChanges();
                       
            return View(db.Artigos.ToList());
        }

        // GET: Artigo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artigo artigo = db.Artigos.Find(id);
            if (artigo == null)
            {
                return HttpNotFound();
            }
            return View(artigo);
        }

        // GET: Artigo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artigo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titulo,Descricao,Autor")] Artigo artigo)
        {
            if (ModelState.IsValid)
            {
                db.Artigos.Add(artigo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artigo);
        }

        // GET: Artigo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artigo artigo = db.Artigos.Find(id);
            if (artigo == null)
            {
                return HttpNotFound();
            }
            return View(artigo);
        }

        // POST: Artigo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titulo,Descricao,Autor")] Artigo artigo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artigo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artigo);
        }

        // GET: Artigo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artigo artigo = db.Artigos.Find(id);
            if (artigo == null)
            {
                return HttpNotFound();
            }
            return View(artigo);
        }

        // POST: Artigo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artigo artigo = db.Artigos.Find(id);
            db.Artigos.Remove(artigo);
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
