using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KantoorApplicatie.Views;
using KantoorApplicatie.Controllers;
using KantoorApplicatie.Models;
namespace UnitTestKantoorApplicatie
{
    /// <summary>
    /// Summary description for DesignPanelTests
    /// </summary>
    [TestClass]
    public class DesignPanelTests
    {

        private DesignPanel dp;
        private DesignPanelController dpc;
        private Room room;
        private List<Line> lines;
        public DesignPanelTests()
        {
            dp = new DesignPanel();
            dpc = new DesignPanelController(dp);
            room = new Room();
            room.productList = new List<Product>();
            lines = new List<Line>
            {
                new Line(10,10,70,50),
                new Line(70,50,30,10),
                new Line(30,10,10,50),
                new Line(10,50,10,10)
            };
        }

        [TestMethod]
        public void SearchLowestAndHighestValuesInCorners_ShouldSetLowestAndHighestValuesOfEachCorner_WhenListOfLinesIsGiven()
        {
            dpc.SetLowestAndHighestValuesInCorners(lines);

            Assert.AreEqual(10, dpc.lowestXValue);
            Assert.AreEqual(70, dpc.highestXValue);
            Assert.AreEqual(10, dpc.lowestYValue);
            Assert.AreEqual(50, dpc.highestYValue);
        }
    }
}
