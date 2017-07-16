using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Introducao.Models;

namespace Introducao.Controllers
{
    public class CategoriasController : Controller
    {
        #region Lista de Categorias
        private static IList<Categoria> categorias = new List<Categoria>()
            {
                new Categoria() { IdCategoria = 1, Nome = "Notebooks" },
                new Categoria() { IdCategoria = 2, Nome = "Monitores" },
                new Categoria() { IdCategoria = 3, Nome = "Impressoras" },
                new Categoria() { IdCategoria = 4, Nome = "Mouses" },
                new Categoria() { IdCategoria = 5, Nome = "Desktops" }
            };
        #endregion

        public ActionResult Index()
        {
            return View(categorias);
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Categoria categoria)
        {
            categoria.IdCategoria = categorias.Count + 1;
            categorias.Add(categoria);

            //Inserindo o ID com LINQ
            //categoria.IdCategoria = categorias.Select(m => m.IdCategoria).Max() + 1;

            return RedirectToAction("index");
        }
    }
}