using TechTalk.SpecFlow;
using PageObjects.Login;
using Utilities;
using NUnit.Framework;

[Binding]
public class LoginSteps
{
    private readonly ScenarioContext _scenarioContext;

    public LoginSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        WebUtilities.NavigateToUrl(Hooks.GetDriver(), "{{url}}");
    }

    [When("I enter valid username '(.*)' and password '(.*)'")]
    public void WhenIEnterValidUsernameAndPassword(string username, string password)
    {
        LoginPage_Actions.EnterUsername(Hooks.GetDriver(), username);
        LoginPage_Actions.EnterPassword(Hooks.GetDriver(), password);
        LoginPage_Actions.ClickLoginButton(Hooks.GetDriver());
    }

    [Then("I should be logged in and redirected to the products page")]
    public void ThenIShouldBeLoggedInAndRedirectedToTheProductsPage()
    {
        // Add assertions for successful login and redirection
    }

    // Implement other steps for different scenarios with appropriate assertions
}