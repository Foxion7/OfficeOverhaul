using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KantoorApplicatie.Views.Invoice;
using System.Collections.Generic;
using KantoorApplicatie.Models;
using KantoorApplicatie.Db;
using KantoorApplicatie.Controllers;

namespace UnitTestKantoorApplicatie
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void FillDisplayedProductList_FillingInvoiceForm_RetrievesNonDoubleProducts()
        {
            // Arrange
            Chair doublechair = new Chair("Hünke Tünke", "Een leren stoel", 30, 30, 49.99, "unitTestImage.bmp");
            Chair doublechair2 = new Chair("Hünke Tünke", "Een leren stoel", 30, 30, 49.99, "unitTestImage.bmp");
            doublechair.productId = 9;
            doublechair2.productId = 9;

            List<Product> productList = new List<Product> {
                doublechair,
                new Sofa("Hanke hunke", "Een gele bank", 40, 80, 79.99,  "unitTestImage.bmp"),
                doublechair
            };
            InvoiceListPanel ilp = new InvoiceListPanel();
            InvoiceController ic = new InvoiceController(ilp, productList);

            // Act
            ic.FillDisplayedProductList();

            // Assert
            Assert.AreEqual(2, ic.productPanelList.Count);
        }
    }
}
