using ComponentLibrary.HelperFunctions;
using OpenQA.Selenium;
using System;

namespace ComponentLibrary.Actions
{
    public class WaitFor
    {
        public static void Element(IWebDriver driver, By id)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Find.Element(driver, id);
            TakeScreenshot.SaveAs(driver, "C:\\CSharpUITestProject\\UITestProject\\UITests", "testScreenshotMethod");
        }
    }
}
