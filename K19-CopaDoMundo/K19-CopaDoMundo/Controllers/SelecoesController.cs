﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K19_CopaDoMundo.Models;

namespace K19_CopaDoMundo.Controllers
{
    public class SelecoesController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Create()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }

        [HttpPost]
        public ActionResult Create(Selecao selecao)
        {
            if (ModelState.IsValid) 
            {
                unitOfWork.SelecaoRepository.Adiciona(selecao);
                unitOfWork.Salva();
                return RedirectToAction("Index");
            }
            return View(selecao);
        }

        public ActionResult Index() 
        {
            return View(unitOfWork.SelecaoRepository.Selecoes);
        }

        public ActionResult Delete(int id) 
        {
            Selecao selecao = unitOfWork.SelecaoRepository.Busca(id);
            return View(selecao);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            unitOfWork.SelecaoRepository.Remove(id);
            unitOfWork.Salva();
            return RedirectToAction("Index");
        }

    }

    
}