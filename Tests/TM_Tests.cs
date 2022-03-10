using February2022.Pages;
using February2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace February2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests: CommonDriver
    {
        [Test, Order (1), Description("Check if user is able to create a Material record with valid data")]
        public void CreateTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);

            // TM page object initialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);
        }

        [Test, Order (2), Description("Check if user is able to edit a Material record with valid data")]
        public void EditTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);

            // Edit TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTM(driver, "dummy", "dummy2", "dummy3");
        }

        [Test, Order (3), Description("Check if user is able to delete an existing Material record")]
        public void DeleteTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);

            // Delete TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTM(driver);
        }
    }
}
