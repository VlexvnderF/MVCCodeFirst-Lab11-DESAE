using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_University.Models
{
    public class DemoContext : DbContext
    {
        public DemoContext(): base("name = MyContextDB")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}