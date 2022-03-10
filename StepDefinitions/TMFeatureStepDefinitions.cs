using February2022.Pages;
using February2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace February2022.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        // Initializing page objects
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tMPageObj = new TMPage();

        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();

            loginPageObj.LoginSteps(driver);
        }

        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
                       
            homePageObj.GoToTMpage(driver);
        }

        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            
            tMPageObj.CreateTM(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tMPageObj.GetCode(driver);
            string newTypeCode = tMPageObj.GetTypeCode(driver);
            string newDescription = tMPageObj.GetDescription(driver);
            string newPrice = tMPageObj.GetPrice(driver);

            Assert.That(newCode == "February2022", "Actual code and expected code do not match");
            Assert.That(newTypeCode == "M", "Actual typecode and expected typecode do not match");
            Assert.That(newDescription == "February2022", "Actual description and expected description do not match");
            Assert.That(newPrice == "$12.00", "Actual price and expected price do not match");
        }

        [When(@"I update '([^']*)', '([^']*)', '([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string p0, string p1, string p2)
        {
            tMPageObj.EditTM(driver, p0, p1, p2);
        }

        [Then(@"the record should have the updated '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string p0, string p1, string p2)
        {
            string editedDescription = tMPageObj.GetEditedDescription(driver);
            string editedCode = tMPageObj.GetEditedCode(driver);
            string editedPrice = tMPageObj.GetEditedPrice(driver);


            Assert.That(editedDescription == p0, "Actual description and expected description do not match");
            Assert.That(editedCode == p1, "Actual code and expected code do not match");
            Assert.That(editedPrice == p2, "Actual price and expected price do not match");

        }



    }
}
