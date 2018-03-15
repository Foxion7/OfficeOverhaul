using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KantoorApplicatie;
using KantoorApplicatie.Models;
using KantoorApplicatie.Views;

namespace KantoorApplicatie.Database {
    class DatabaseController {

        CatalogPanel pp;

        public DatabaseController(CatalogPanel pp) {
            this.pp = pp;
        }

        public void StartStuff() {
            using (var context = new MyContext()) {
                var bank001 = new Bank("SklerBljeg", "Een hele mooie oranje sofa uit het noorden van Zweden, Hunke Tünke", 40, 20);
                if (!context.producten.Where(b => b.name == bank001.name).Any())
                    context.producten.Add(bank001);
               var stoel001 = new Stoel("SkonBljat", "Een mooie blauwe stoel", 10, 10);
                if (!context.producten.Where(b => b.name == stoel001.name).Any())
                    context.producten.Add(stoel001);
                context.SaveChanges();

                List<Product> products = new List<Product>();
                foreach(Product product in context.producten) {
                    products.Add(product);
                }

            }
        }
    }
}

