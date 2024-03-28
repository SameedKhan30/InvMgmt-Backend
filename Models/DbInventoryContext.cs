using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace InvMgmt.Models
{
    public class DbInventoryContext:DbContext
    {
        public DbInventoryContext(DbContextOptions<DbInventoryContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public  DbSet<Sales> Sales { get; set; }
        public  DbSet<Purchase> Purchase { get; set; }  
     
    } 
}

