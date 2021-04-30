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
            List<int> kategoriIds = new List<int>();
            kategoriIds.Add(1);
            kategoriIds.Add(2);

            List<Kategori> kategoriler = new List<Kategori>();
            foreach (var ktgId in kategoriIds)
            {
                var ktg = context.Kategoriler.FirstOrDefault(x => x.Id == ktgId);
                kategoriler.Add(ktg);
            }
          
            Kitap kitap = new Kitap()
            {
                Ad = "Veba Geceleri",
                Adet = 100,
                EklenmeTarihi = DateTime.Now,
                SiraNo = "1",
                YazarId = 1,
                Kategoriler = kategoriler
               
            };
            context.Kitaplar.Add(kitap);
            context.SaveChanges();
            return View();
        }
    }
}