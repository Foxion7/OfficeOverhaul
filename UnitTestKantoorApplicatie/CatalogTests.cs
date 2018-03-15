using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KantoorApplicatie.Views;
using System.Collections.Generic;
using KantoorApplicatie.Controllers;
using KantoorApplicatie.Models;
using KantoorApplicatie.Db;
using System.Drawing;
using System.Linq;

namespace UnitTestKantoorApplicatie
{
    [TestClass]
    public class CatalogTests
    {
        //Product p = DatabaseController.GetProducts()[0];
        [TestMethod]
        public void RemoveNonSearchedProducts_ShouldReturnListWithProductsThatHaveTheCatalogsSearchTermInTheirName_WhenGivenListOfProducts() {
            // Arrange
            List<Product> productList = new List<Product> {
                new Chair("Hünke Tünke", "Een leren stoel", 30, 30, 49.99, "unitTestImage.bmp"),
                new Sofa("Hanke hunke", "Een gele bank", 40, 80, 79.99,  "unitTestImage.bmp"),
                new Chair("Hünke Tünke", "Een leren stoel", 30, 30, 49.99,  "unitTestImage.bmp")
            };
            CatalogPanel cp = new CatalogPanel();
            CatalogController cc = new CatalogController(new CatalogListPanel(), new DesignPanel());
            List<Product> filteredList = new List<Product>();
            string searchString = "T";

            // Act
            cc.currentSearch = searchString;
            filteredList = cc.RemoveNonSearchedProducts(productList);

            // Assert
            foreach (Product p in filteredList) {
                Assert.IsTrue(p.name.Contains(searchString));
            }
        }

        [TestMethod]
        public void RemoveNonSortedProducts_ShouldReturnListWithProductsThatHaveTheCatalogsSortTermAsTheirType_WhenGivenListOfProducts() {

            // Arrange
            List<Product> productList = new List<Product> {
                new Chair("Hünke Tünke", "Een leren stoel", 30, 30, 49.99,  "unitTestImage.bmp"),
                new Sofa("Hanke hunke", "Een gele bank", 40, 80, 79.99,  "unitTestImage.bmp"),
                new Chair("Hünke Tünke", "Een leren stoel", 30, 30, 49.99,  "unitTestImage.bmp")
            };
            CatalogPanel cp = new CatalogPanel();
            CatalogController cc = new CatalogController(new CatalogListPanel(), new DesignPanel());
            List<Product> filteredList = new List<Product>();
            string sortString = "Sofa";

            // Act
            cc.currentSorting = sortString;
            filteredList = cc.RemoveNonSortedProducts(productList);

            // Assert
            foreach (Product p in filteredList) {
                Assert.IsTrue(p.GetType().ToString() == "KantoorApplicatie.Models." + sortString);
            }
        }


        [TestMethod]
        public void OrderProducts_ShouldOrdersAllProductsInOrderOfCatalogsOrdering_WhenGivenListOfProducts() {

            // Arrange
            List<Product> productList = new List<Product> {
                new Chair("Hünke Tünke", "Een leren stoel", 30, 30, 49.99,  "unitTestImage.bmp"),
                new Sofa("Hanke hunke", "Een gele bank", 40, 80, 79.99,  "unitTestImage.bmp"),
                new Chair("Hünke Tünke", "Een leren stoel", 30, 30, 49.99,  "unitTestImage.bmp")
            };
            CatalogPanel cp = new CatalogPanel();
            CatalogController cc = new CatalogController(new CatalogListPanel(), new DesignPanel());
            List<Product> filteredList = new List<Product>();
            string orderString = "Naam: A-Z";

            // Act
            cc.currentOrdering = orderString;

            List<Product> expectedList = new List<Product>();
            expectedList = productList.OrderBy(x => x.name).ToList();
            filteredList = cc.OrderProducts(productList);

            // Assert
            for (int i = 0; i < filteredList.Count; i++){
                Assert.AreEqual(filteredList[i], expectedList[i]);
            }
        }
    }
}
