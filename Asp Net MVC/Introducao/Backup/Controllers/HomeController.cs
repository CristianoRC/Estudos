﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }

        #region Retornando strings
        //public string Index()
        //{
        //    return "Ola Mundo ASP NET MVC";
        //}

        //public string Sobre()
        //{
        //    return "Sobre - Aulas ASP NET MVC";
        //}
        #endregion

    }
}