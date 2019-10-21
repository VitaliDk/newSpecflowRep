using ComponentLibrary.HelperFunctions;
using OpenQA.Selenium;

namespace ComponentLibrary.Actions
{
    public class VerifyExistsOnPage
    {
        public static void Element(IWebDriver driver, By id)
        {
            Find.Element(driver, id);
        }
    }
}
