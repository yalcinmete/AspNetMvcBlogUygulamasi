using AspNetMvcBlogUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcBlogUygulamasi.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var bloglar = context.Bloglar
                                .Where(i => i.Onay == true && i.Anasayfa == true)
                                 .Select(i => new BlogModel()
                                 {
                                     Id = i.Id,
                                     Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                                     Aciklama = i.Aciklama,
                                     EklenmeTarihi = i.EklenmeTarihi,
                                     Anasayfa = i.Anasayfa,
                                     Onay = i.Onay,
                                     Resim = i.Resim,
                                 });
                                 
            //return View(context.Bloglar.ToList());
            return View(bloglar.ToList());
        }
    }
}