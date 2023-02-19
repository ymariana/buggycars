using System;
using TechTalk.SpecFlow;

namespace BuggyCars.StepDefinitions
{
    [Binding]
    public class NavigationTestStepDefinitions
    {
        private readonly DriverContext _driverContext;
        private readonly Context _context;

        public NavigationTestStepDefinitions(DriverContext driverContext, Context context)
        {
            _driverContext = driverContext;
            _context = context;
        }

        [When(@"I click the logo link")]
        public void WhenIClickTheLogoLink()
        {
            _context.OverallPage.BuggyRatingLogo.Click();
        }

        [Then(@"I should be redirected to the main page")]
        public void ThenIShouldBeRedirectedToTheMainPage()
        {
            Assert.Equal("https://buggy.justtestit.org/", _driverContext.driver.Url.ToString());           
        }


        [Given(@"I navigate to the Make page")]
        public void GivenINavigateToTheMakePage()
        {
            _driverContext.driver.Navigate().GoToUrl("https://buggy.justtestit.org/make/c4u1mqnarscc72is00ng");
        }

        [Given(@"I navigate to the Model page")]
        public void GivenINavigateToTheModelPage()
        {
            _driverContext.driver.Navigate().GoToUrl("https://buggy.justtestit.org/model/c4u1mqnarscc72is00e0|c4u1mqnarscc72is00kg");
        }
    }
}
