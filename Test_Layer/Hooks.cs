using TechTalk.SpecFlow;
using Utilities;

[Binding]
public class Hooks
{
    private static IWebDriver driver;

    [BeforeScenario]
    public void BeforeScenario()
    {
        driver = WebUtilities.InitializeDriver("chrome");
    }

    [AfterScenario]
    public void AfterScenario()
    {
        WebUtilities.QuitDriver(driver);
    }

    public static IWebDriver GetDriver()
    {
        return driver;
    }
}