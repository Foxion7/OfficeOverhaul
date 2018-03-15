﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KantoorApplicatie;
using KantoorApplicatie.Models;
using KantoorApplicatie.Views;
using KantoorApplicatie.Controllers;

namespace UnitTestKantoorApplicatie
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void PlaceProduct_ShouldAddProductToDesignPanel_WhenProductIsDropped()
        {
            //Arrange
            Product p = new Chair();
            DesignPanel dp = new DesignPanel();
            Room r = new Room();
            dp.rDesign = r;
            dp.rDesign.productList = new List<Product>();

            //Act
            dp.AddProduct(p);
            int expected = 1;

            //Assert
            Assert.AreEqual(expected, dp.rDesign.productList.Count);
        }

        [TestMethod]
        public void DeleteProduct_ShouldDeleteProductFromDesignPanel_WhenDeleteButtonIsClicked()
        {
            //Arrange
            Product p = new Chair();
            DesignPanel dp = new DesignPanel();
            Room r = new Room();
            dp.rDesign = r;
            dp.rDesign.productList = new List<Product>();
            dp.AddProduct(p);

            //Act
            dp.DeleteProduct(p);
            int expected = 0;

            //Assert
            Assert.AreEqual(expected, dp.rDesign.productList.Count);
        }
    }
}
