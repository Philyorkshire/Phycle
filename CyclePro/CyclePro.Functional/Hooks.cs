using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using TechTalk.SpecFlow;

namespace CyclePro.Functional
{
    [Binding]
    public class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (Driver == null) return;

            Driver.Quit();
            Driver.Dispose();
        }
    }
}
