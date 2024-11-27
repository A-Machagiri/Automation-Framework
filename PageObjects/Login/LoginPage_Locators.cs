using OpenQA.Selenium;

namespace PageObjects.Login
{
    public static class LoginPage_Locators
    {
        public static By UsernameField = By.Id("username");
        public static By PasswordField = By.Id("password");
        public static By LoginButton = By.Id("login-button");
        public static By ErrorMessage = By.CssSelector("h3[data-test='error']");
        // Add locators for elements on the product page after login for assertion
    }
}