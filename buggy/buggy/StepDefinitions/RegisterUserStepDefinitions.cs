using TechTalk.SpecFlow;

namespace BuggyCars.StepDefinitions
{
    [Binding]
    public class RegisterUserStepDefinitions 
    {
        private readonly Context _context;
        private readonly DriverContext _driverContext;
        private readonly ScenarioContext _scenarioContext;


        public RegisterUserStepDefinitions(Context context, DriverContext driverContext, ScenarioContext scenarioContext)  
        {
            _context = context;
            _driverContext = driverContext;
            _scenarioContext = scenarioContext;
        }

    [   Given(@"I am in the registration page")]
        public void GivenIAmInTheRegistrationPage()
        {
            _driverContext.driver.Navigate().GoToUrl("https://buggy.justtestit.org/register");
        }

        
        [When(@"I enter the following info")]
        public void WhenIEnterTheFollowingInfo()
        {
            string login = Faker.Name.First() + Faker.RandomNumber.Next(100);
            string password = "Test160223001@";

            _context.RegisterPage.EnterData(login, password);
            _context.RegisterPage.ClickRegisterButton();
        }

        [Then(@"user should be registered")]
        public void ThenUserShouldBeRegistered()
        {
            Assert.True(_context.RegisterPage.SuccessfulMessageDisplayed());
        }

        [Given(@"a new user is created")]
        public void GivenANewUserIsCreated()
        {
            _driverContext.driver.Navigate().GoToUrl("https://buggy.justtestit.org/register");
            string login = Faker.Name.First() + Faker.RandomNumber.Next(100);
            string password = "Test160223001@";
            _scenarioContext.Add("user", login);
            _scenarioContext.Add("password", password);
            _context.RegisterPage.EnterData(login, password);

            _context.RegisterPage.ClickRegisterButton();
            Assert.True(_context.RegisterPage.SuccessfulMessageDisplayed());
        }

    }
}
