using OpenQA.Selenium;
using Utilities;

namespace PageObjects.Login
{
    public partial class LoginPage_Actions
    {
        public static void EnterUsername(IWebDriver driver, string username)
        {
            WebUtilities.SendKeysToElement(WebUtilities.FindElement(driver, LoginPage_Locators.UsernameField), username);
        }

        public static void EnterPassword(IWebDriver driver, string password)
        {
            WebUtilities.SendKeysToElement(WebUtilities.FindElement(driver, LoginPage_Locators.PasswordField), password);
        }

        public static void ClickLoginButton(IWebDriver driver)
        {
            WebUtilities.ClickElement(WebUtilities.FindElement(driver, LoginPage_Locators.LoginButton));
        }

        // Add methods for interacting with elements on the product page after login
    }
}