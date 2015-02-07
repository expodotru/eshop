using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EShop.Models
{
    public class EshopContext : DbContext
    {
        public EshopContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}