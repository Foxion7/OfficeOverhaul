using KantoorApplicatie.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantoorApplicatie.Database {

    public class MyContext : DbContext {
        public MyContext() : base("Catalogus") { }

        public DbSet<Product> producten { get; set; }
        public DbSet<Lamp> lampen { get; set; }
    }
}
