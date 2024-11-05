using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMvcBlogUygulamasi.Models
{
    //bu seed classının calısması için tablo şemasında (DropCreateDatabaseIfModelChanges) değişiklik olması gerekir 
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() {KategoriAdi = "C#"},
                new Category() {KategoriAdi ="Asp.net MVC"},
                new Category() {KategoriAdi="Asp.net WebFrom"},
                new Category() {KategoriAdi= "Windows Form"},
            };


            foreach (var item in kategoriler) 
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){ Baslik="C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates HakkindaC# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="1.jpg" , CategoryId = 1},
                new Blog(){ Baslik="C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="1.jpg" , CategoryId = 1},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-30),Anasayfa=false, Onay = false,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="1.jpg" , CategoryId = 1},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-20),Anasayfa=true, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda  C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="2.jpg" , CategoryId = 2},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Generic List C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-5),Anasayfa=true, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="1.jpg" , CategoryId = 2},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=false, Onay = false,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="2.jpg" , CategoryId = 2},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="2.jpg" , CategoryId = 3},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=false, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="2.jpg" , CategoryId = 3},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-15),Anasayfa=true, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="1.jpg" , CategoryId = 3},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-17),Anasayfa=true, Onay = false,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="2.jpg" , CategoryId = 4},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="1.jpg" , CategoryId = 4},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="1.jpg" , CategoryId = 4},
                new Blog(){ Baslik="C# Delegates Hakkinda" , Aciklama = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay = true,Icerik = "C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda C# Delegates Hakkinda",Resim="1.jpg" , CategoryId = 4},
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges(); 

            base.Seed(context);
        }
    }
}