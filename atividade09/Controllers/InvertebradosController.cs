using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using atividade09.DAL;
using atividade09.Models;

namespace atividade09.Controllers
{
    public class InvertebradosController : Controller
    {
        private AnimalContext db = new AnimalContext();

        // GET: Invertebrados
        public ActionResult Index()
        {
            return View(db.Invertebrados.ToList());
        }

        // GET: Invertebrados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invertebrados invertebrados = db.Invertebrados.Find(id);
            if (invertebrados == null)
            {
                return HttpNotFound();
            }
            return View(invertebrados);
        }

        // GET: Invertebrados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Invertebrados/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,classe,categoria,exoesqueleto,tamanho_centimetros,nome,regiao,familia,quantidade_patas,anfibio")] Invertebrados invertebrados)
        {
            if (ModelState.IsValid)
            {
                db.Invertebrados.Add(invertebrados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(invertebrados);
        }

        // GET: Invertebrados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invertebrados invertebrados = db.Invertebrados.Find(id);
            if (invertebrados == null)
            {
                return HttpNotFound();
            }
            return View(invertebrados);
        }

        // POST: Invertebrados/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,classe,categoria,exoesqueleto,tamanho_centimetros,nome,regiao,familia,quantidade_patas,anfibio")] Invertebrados invertebrados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(invertebrados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(invertebrados);
        }

        // GET: Invertebrados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invertebrados invertebrados = db.Invertebrados.Find(id);
            if (invertebrados == null)
            {
                return HttpNotFound();
            }
            return View(invertebrados);
        }

        // POST: Invertebrados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Invertebrados invertebrados = db.Invertebrados.Find(id);
            db.Invertebrados.Remove(invertebrados);
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
