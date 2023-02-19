using Faker;
using TechTalk.SpecFlow;

namespace BuggyCars.StepDefinitions
{
    [Binding]
    public class UpdateUserProfileStepDefinitions
    {
        //private readonly DriverContext _driverContext;
        private readonly Context _context;
        private readonly ScenarioContext _scenarioContext;


        public UpdateUserProfileStepDefinitions(DriverContext driverContext, Context context, ScenarioContext scenarioContext)
        {
            //_driverContext = driverContext;
            _context = context;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to the Profile page")]
        public void GivenINavigateToTheProfilePage()
        {
            _context.ProfilePage.ClickProfileButton();
        }

        [When(@"I send the new values")]
        public void WhenISendTheNewValues()
        {
            var age = "40";
            _scenarioContext.Add("age", age);

            var address = Address.StreetAddress();
            _scenarioContext.Add("address", address);           

            var hobby = "Learning";
            _scenarioContext.Add("hobby", hobby);           

            _context.ProfilePage.AgeField.Clear();
            _context.ProfilePage.AgeField.SendKeys("40");

            _context.ProfilePage.AddressField.Clear();
            _context.ProfilePage.AddressField.SendKeys(address);

            _context.ProfilePage.SelectHobby(hobby);

            _context.ProfilePage.ClickSaveButton();
        }

        [Then(@"profile should be updated")]
        public void ThenProfileShouldBeUpdated()
        {
            Assert.True(_context.ProfilePage.UpdatedSuccessfulMessage.Displayed);

            Assert.Equal(_scenarioContext["age"], _context.ProfilePage.AgeField.GetAttribute("value"));
            Assert.Equal(_scenarioContext["address"], _context.ProfilePage.AddressField.GetAttribute("value"));
            Assert.Equal(_scenarioContext["hobby"], _context.ProfilePage.HobbyField.GetAttribute("value"));
        }
    }
}
