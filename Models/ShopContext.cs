using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApi.Models
{ 
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        public DbSet<ShopModel> Shops { get; set; }
        public DbSet<ItemModel> Items { get; set; }
        public DbSet<ShippmentModel> Shippments { get; set; }
    }
}
