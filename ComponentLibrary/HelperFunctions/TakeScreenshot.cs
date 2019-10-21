using OpenQA.Selenium;

namespace ComponentLibrary.HelperFunctions
{
    public class TakeScreenshot
    {
        public static void SaveAs(IWebDriver driver, string filePath, string fileName)
        {
            var ssdriver = driver as ITakesScreenshot;
            var screenshot = ssdriver.GetScreenshot();
            var location = filePath + "\\" + fileName + ".Png";
            screenshot.SaveAsFile(location, ScreenshotImageFormat.Png);
        }
    }
}
