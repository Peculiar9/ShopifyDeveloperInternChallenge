using ImagierWebDomain.AuthModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagierWebDomain.EntityModels
{
   public class ImageDbContext:IdentityDbContext<ApplicationUser>
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {

        }

       public DbSet<ImageAsset> ImageAssets { get; set; }
       public DbSet<ApplicationUser> ApplicationUsers { get; set; }
       //public DbSet<RegisterModel> RegisterModel { get; set; }
       public DbSet<Cart> Cart { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
