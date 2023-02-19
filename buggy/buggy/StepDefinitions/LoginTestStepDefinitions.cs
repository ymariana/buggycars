using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace BuggyCars.StepDefinitions
{
    [Binding]
    public class LoginTestStepDefinitions 
    {
        private readonly DriverContext _driverContext;
        private readonly Context _context;
        private readonly ScenarioContext _scenarioContext;


        public LoginTestStepDefinitions(DriverContext driverContext, Context context, ScenarioContext scenarioContext)
        { 
            _driverContext = driverContext;
            _context = context;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am in the home page")]
        public void GivenIAmInTheHomePage()
        {
            _driverContext.driver.Navigate().GoToUrl("https://buggy.justtestit.org");
            Assert.Equal("Buggy Cars Rating", _driverContext.driver.Title);
        }

        [When(@"I enter invalid credentials")]
        public void WhenIEnterTheLoginAndPassword()
        {
            _context.LoginPage.EnterCredentialsAndSubmit("test", "test");
        }

        [Then(@"I should not be logged in")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            Assert.True(_context.LoginPage.UnsuccessfulLoginErrorDisplayed());
        }

        [Given(@"I enter valid credentials")]
        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _context.LoginPage.EnterCredentialsAndSubmit(_scenarioContext.Get<string>("user"), _scenarioContext.Get<string>("password"));
        }

        [Given(@"I should be logged in")]
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            Assert.True(_context.LoginPage.LoginSuccessfulMessage.Displayed);
        }

    }
}
