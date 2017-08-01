using System.Collections.Generic;
using System.Linq;
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
            return View(categorias.OrderBy(x => x.IdCategoria));
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

            return RedirectToAction("index");
        }

        public ActionResult Editar(long ID)
        {
            var categoriaTemp = categorias.Where(m => m.IdCategoria.Equals(ID)).First();

            return View(categoriaTemp);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Editar(Categoria _categoria)
        {
            categorias.Remove(categorias.Where(x => x.IdCategoria == _categoria.IdCategoria).First());

            categorias.Add(_categoria);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Deletar(long ID)
        {
            categorias.Remove(categorias.Where(x => x.IdCategoria == ID).First());

            return RedirectToAction("Index");
        }
    }
}