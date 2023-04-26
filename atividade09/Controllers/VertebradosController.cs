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
    public class VertebradosController : Controller
    {
        private AnimalContext db = new AnimalContext();

        // GET: Vertebrados
        public ActionResult Index()
        {
            return View(db.Vertebrados.ToList());
        }

        // GET: Vertebrados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vertebrados vertebrados = db.Vertebrados.Find(id);
            if (vertebrados == null)
            {
                return HttpNotFound();
            }
            return View(vertebrados);
        }

        // GET: Vertebrados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vertebrados/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,tem_pelos,raca,penas,tamanho_metros,nome,regiao,familia,quantidade_patas,anfibio")] Vertebrados vertebrados)
        {
            if (ModelState.IsValid)
            {
                db.Vertebrados.Add(vertebrados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vertebrados);
        }

        // GET: Vertebrados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vertebrados vertebrados = db.Vertebrados.Find(id);
            if (vertebrados == null)
            {
                return HttpNotFound();
            }
            return View(vertebrados);
        }

        // POST: Vertebrados/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,tem_pelos,raca,penas,tamanho_metros,nome,regiao,familia,quantidade_patas,anfibio")] Vertebrados vertebrados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vertebrados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vertebrados);
        }

        // GET: Vertebrados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vertebrados vertebrados = db.Vertebrados.Find(id);
            if (vertebrados == null)
            {
                return HttpNotFound();
            }
            return View(vertebrados);
        }

        // POST: Vertebrados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vertebrados vertebrados = db.Vertebrados.Find(id);
            db.Vertebrados.Remove(vertebrados);
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
