using TechTalk.SpecFlow;
using ComponentLibrary.Actions;
using ComponentLibrary.Screens;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ComponentLibrary.Tasks;

namespace UITests.Steps
{
    [Binding]
    public class IdentityProviderSteps
    {

        private readonly IWebDriver driver;

        private static readonly Logger _Logger = LogManager.GetCurrentClassLogger();

        public IdentityProviderSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            GoTo.DMILoginPage(driver);
        }

        [When(@"the user attempts to log in")]
        public void WhenTheUserAttemptsToLogIn()
        {
            LoginTo.DMI(driver);
        }

        [When(@"the user attempts to log in with an invalid username")]
        public void WhenTheUserAttemptsToLogInWithAnInvalidUsername()
        {
            LoginTo.DMIWithInvalidUsername(driver);
        }

        [When(@"the user attempts to log in with an invalid password")]
        public void WhenTheUserAttemptsToLogInWithAnInvalidPassword()
        {
            LoginTo.DMIWithInvalidPassword(driver);
        }

        [When(@"the user attempts to log out")]
        public void WhenTheUserAttemptsToLogOut()
        {
            Logout.DMI(driver);
        }

        [Then(@"the user is redirected to the DMI")]
        public void ThenTheUserIsRedirectedToTheDMI()
        {
            VerifyExistsOnPage.Element(driver, DMIDashboardPage.Dashboard);

        }

        [Then(@"the user is redirected to the DMI login page")]
        public void ThenTheUserIsRedirectedToTheDMILoginPage()
        {
            VerifyExistsOnPage.Element(driver, DMILoginPage.UsernameField);

        }

        [Given(@"the user is logged into the DMI")]
        public void GivenTheUserIsLoggedIntoTheDMI()
        {
            GivenTheUserIsOnTheLoginPage();
            WhenTheUserAttemptsToLogIn();
            ThenTheUserIsRedirectedToTheDMI();
        }


        [Then(@"the user is shown a validation message explaining that their login attempt was unsuccessful")]
        public void ThenTheUserIsUnsuccessfulInLoggingIntoTheDMI()
        {
            VerifyExistsOnPage.Element(driver, DMILoginPage.InvalidLoginAttemptMessage);
        }
    }
}
