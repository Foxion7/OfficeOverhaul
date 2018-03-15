using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using KantoorApplicatie;
using KantoorApplicatie.Models.Theme;
using KantoorApplicatie.Views;

namespace UnitTestKantoorApplicatie
{
    [TestClass]
    public class ThemeTest
    {
        
        //Theme
        [TestMethod]
        public void AddSubTheme_ShouldAddSubTheme_WhenSubThemeIsGiven()
        {
            //Arrange
            Theme t1 = new Theme("school");
            SubTheme s1 = new SubTheme("school1", new Bitmap(20,20), t1);
            int expected = 1;
            //Act
            t1.subThemes.Add(s1);
            //Assert
            int actual = t1.subThemes.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddSubTheme_ShouldAddCorrectSubTheme_WhenSubThemeIsGiven()
        {
            //Arrange
            Theme t1 = new Theme("School");
            SubTheme s1 = new SubTheme("School1", new Bitmap(20, 20), t1);
            SubTheme expected = s1;
            //Act
            t1.subThemes.Add(s1);
            //Assert
            SubTheme actual = t1.subThemes.First();
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void InsertImage_ShouldInsertCorrectBackgroundAndLastSelectedImage_WhenSubThmeIsGiven()
        //{
        //    //Arange
        //    var bm = new 
        //    SubTheme s1 = new SubTheme("School1",);
        //}
    }
}
