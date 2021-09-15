using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagierWebDomain.EntityModels
{
    public class ImagierDbContext : DbContext
    {
        public ImagierDbContext(DbContextOptions<ImagierDbContext> options) : base(options)
        {

        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ImageAsset> ImageAssets { get; set; }
        public DbSet<Repository> Repository { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
