using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class CidadesController : BaseController
    {
        private CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities(); 
        // GET: Cidades
        public ActionResult Index()
        {
            var cidade = db.Cidades.ToList();
            
            return View(cidade);
        }

        public ActionResult Adicionar()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cidades cidade)
        {

            if (ModelState.IsValid)
            {
                db.Cidades.Add(cidade);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Editar(long id)
        {
            Cidades cidade = db.Cidades.Find(id);

            return View(cidade);
        }

        [HttpPost]
        public ActionResult Editar(Cidades cidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
                Cidades cidade = db.Cidades.Find(id);
                db.Cidades.Remove(cidade);
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
        }
    }
}