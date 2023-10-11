using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        // public DbSet<Product> Products {set; get;}
        // public DbSet<ProductType> ProductTypes { get; set; }
        // public DbSet<ProductBrand> ProductBrands { get; set; }


    }
}