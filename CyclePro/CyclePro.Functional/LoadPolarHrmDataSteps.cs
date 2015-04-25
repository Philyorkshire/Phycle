using NUnit.Framework;

using OpenQA.Selenium;

using TechTalk.SpecFlow;

namespace CyclePro.Functional
{
    [Binding]
    public class LoadPolarHrmDataSteps : Hooks
    {
        [Given(@"I am on the home page")]
        public void GivenIHamOnTheHomePage()
        {
            Driver.Navigate().GoToUrl(PageNames.HomePage.GetUrl());
            var titleText = Driver.FindElement(By.Id("title")).Text;

            Assert.AreEqual("Cycle Analysis", titleText);
        }

        [When(@"I upload a valid polar hrm file")]
        public void WhenIUploadAValidPolarHrmFile()
        {
            var uploadFileButton = Driver.FindElement(By.Id("fileUpload"));
            var uploadButton = Driver.FindElement(By.Id("upload"));

            uploadFileButton.SendKeys("C:\\Users\\phillip\\Documents\\GitHub\\Phycle\\CyclePro\\CyclePro.Functional\\ASDExample.hrm");
            uploadButton.Click();
        }

        [Then(@"I am redirected to the dashboard")]
        public void ThenIAmShownCyclingData()
        {
            var headerText = Driver.FindElement(By.ClassName("header-title")).Text;
            Assert.AreEqual("Dashboard", headerText);
        }

        [When(@"I navigate to the Raw Data View")]
        public void WhenINavigateToTheRawDataView()
        {
            Driver.Navigate().GoToUrl(PageNames.Raw.GetUrl());
            var headerText = Driver.FindElement(By.ClassName("header-title")).Text;
            Assert.AreEqual("Raw Data View", headerText);
        }

        [Then(@"'(.*)' Results are displayed")]
        public void ThenResultsAreDisplayed(int tableCount)
        {
            var tableRows = Driver.FindElements(By.TagName("tr")).Count;
            Assert.AreEqual(tableCount, tableRows);
        }

    }
}
