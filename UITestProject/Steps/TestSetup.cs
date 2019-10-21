using System;
using BoDi;
using TechTalk.SpecFlow;
using ComponentLibrary.Factories;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UITestProject.Steps
{
    [Binding]
    public class TestSetup
    {

        private readonly IObjectContainer _objectContainer;

        public TestSetup(IObjectContainer objectContainer)
        {
            this._objectContainer = objectContainer;
        }
        [BeforeScenario]
        public void InitialiseTest()
        {
            WebDriverFactory factory = new WebDriverFactory();
            IWebDriver driver = factory.Create(BrowserType.Chrome);
            driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void TearDown(IWebDriver driver)
        {
            driver.Close();
            driver.Quit();
        }

    }
}
