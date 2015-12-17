using Aula02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula02.Controllers
{
    public class ArtigoController : Controller
    {
        private Repositories db = new Repositories();

        // GET: Artigo
        public ActionResult Index()
        {
            return View(db.GetArticles());
        }

        // GET: Artigo/Details/5
        public ActionResult Details(int id)
        {
            var aritgo = db.GetArticles().FirstOrDefault(c => c.Id == id);

            return View(aritgo);
        }

        // GET: Artigo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artigo/Create
        [HttpPost]
        public ActionResult Create(Artigo artigo)
        {
            try
            {
                // TODO: Add insert logic here

                db.CreateArticle(artigo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Artigo/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.GetArticles().FirstOrDefault(c => c.Id == id));
        }

        // POST: Artigo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Artigo artigo)
        {
            try
            {
                // TODO: Add update logic here
                db.EditArticle(artigo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Artigo/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.GetArticles().FirstOrDefault(c => c.Id == id));
        }

        // POST: Artigo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Artigo artigo)
        {
            try
            {
                // TODO: Add delete logic here

                db.DeleteArticle(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
