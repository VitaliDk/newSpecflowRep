using System;
using ComponentLibrary.BaseClasses;
using OpenQA.Selenium;

namespace ComponentLibrary.HelperFunctions
{
    public class Find : BaseAction
    {

        public static IWebElement Element(IWebDriver driver, By selector)
        {
            // Return null by default
            IWebElement elementToReturn = null;

            try
            {
                _Logger.Info($"attempt button click.");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                _Logger.Info($"after driver manage script");
                elementToReturn = driver.FindElement(selector);
                _Logger.Info($"Nos such element: {selector} could be found.");
            }
            catch (NoSuchElementException e)
            {
                _Logger.Info($"No such element: {selector} could be found.");
                String format = "dd-mm-yyyy.hh.mm.tt";
                TakeScreenshot.SaveAs(driver, "C:\\Users\\danialk\\Desktop\\CSharpUITestProject_WithIObjectContainer\\UITestProject\\UITests\\Screenshots", DateTime.Now.ToString(format));
                throw new NoSuchElementException("exception thrown", e);
            }
            catch (Exception e)
            {
                _Logger.Info($"No such element: {selector} coulds be found.");
                String format = "dd-mm-yyyy.hh.mm.tt";
                TakeScreenshot.SaveAs(driver, "C:\\Users\\danialk\\Desktop\\CSharpUITestProject_WithIObjectContainer\\UITestProject\\UITests\\Screenshots", DateTime.Now.ToString(format));
                throw e;
            }

            // return either the element or null
            return elementToReturn;
        }
    }
}
