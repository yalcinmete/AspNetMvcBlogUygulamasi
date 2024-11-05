using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMvcBlogUygulamasi.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext():base("blogDb") 
        {
                Database.SetInitializer(new BlogInitializer());//Seed metodu için
        }

        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}