using OpenQA.Selenium.DevTools.V107.Network;
using System;
using TechTalk.SpecFlow;

namespace BuggyCars.StepDefinitions
{
    [Binding]
    public class OverallRatingTestStepDefinitions
    {
        private readonly DriverContext _driverContext;
        private readonly Context _context;
        private readonly ScenarioContext _scenarioContext;

        public OverallRatingTestStepDefinitions(DriverContext driverContext, Context context, ScenarioContext scenarioContext)
        {
            _driverContext = driverContext;
            _context = context;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to the Overall page")]
        [When(@"I navigate to the Overall page")]
        public void WhenINavigateToTheOverallPage()
        {
            _driverContext.driver.Navigate().GoToUrl("https://buggy.justtestit.org/overall");
        }

        [When(@"I navigate to the most popular model")]
        public void WhenINavigateToTheMostPopularModel()
        {
            _context.OverallPage.NavigateToFirstModel();
        }


        [When(@"I vote")]
        public void WhenIVote()
        {
            _scenarioContext.Add("voteCounter", _context.ModelPage.VoteCounter.Text);
            _context.ModelPage.Vote();
        }

        [Then(@"vote should be counted")]
        public void ThenVoteShouldBeCounted()
        {
            Assert.True(_context.ModelPage.VotingSuccessfulMessage.Displayed);

            var oldVoteCounter = Int32.Parse(_scenarioContext.Get<string>("voteCounter"));
            var currentVoteCounter = Int32.Parse(_context.ModelPage.VoteCounter.Text);
            Assert.Equal(oldVoteCounter + 1, currentVoteCounter);
        }
    }
}
