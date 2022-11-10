using Juan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<PraductBanner> PraductBanners { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Tags> Tags { get; set; }
    }
}
