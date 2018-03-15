using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KantoorApplicatie.Views.Themeforms;
using KantoorApplicatie.Controllers;
using KantoorApplicatie.Db;
using KantoorApplicatie.Models.Theme;
using KantoorApplicatie.Models.Invoice;
using KantoorApplicatie.Views.Invoice;
using KantoorApplicatie.Views;

namespace UnitTestKantoorApplicatie
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void SetCustomer_WhenCustomerIsGiven()
        {
            // Arrange
            Customer customer = new Customer();
            MainMenu mm = new MainMenu();
            CustomerForm cf = new CustomerForm(mm);

            // Act
            cf.SetCustomer(customer);

            // Assert
            Customer expected = customer;
            Assert.AreEqual(expected, customer);


        }
    }
}
