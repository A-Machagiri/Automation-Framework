using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace Utilities
{
    public class WebUtilities
    {
        public static IWebDriver InitializeDriver(string browser)
        {
            IWebDriver driver = null;
            if (browser.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (browser.Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else if (browser.Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            return driver;
        }

        public static void NavigateToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static IWebElement FindElement(IWebDriver driver, By locator)
        {
            return driver.FindElement(locator);
        }

        public static void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public static void SendKeysToElement(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static void QuitDriver(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}