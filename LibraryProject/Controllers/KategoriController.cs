using LibraryProject.Data;
using LibraryProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LibraryProject.Controllers
{
    public class KategoriController : Controller
    {
        public ActionResult Index()
        {
            Context context = new Context();
            var kitaplar = context.Kitaplar.ToList();
            return View();
        }
    }
}