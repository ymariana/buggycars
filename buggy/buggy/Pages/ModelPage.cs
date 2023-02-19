using OpenQA.Selenium;

namespace BuggyCars.Pages
{
    public class ModelPage
    {
        private readonly DriverContext _driverContext;

        public IWebElement CommentBox => _driverContext.driver.FindElement(By.Id("comment"));
        public IWebElement VoteButton => _driverContext.driver.FindElement(By.XPath("//button[@class='btn btn-success'][text()='Vote!']"));
        public IWebElement VoteCounter => _driverContext.driver.FindElement(By.CssSelector("div:nth-child(1) > h4 > strong"));
        public IWebElement VotingSuccessfulMessage => _driverContext.driver.FindElement(By.XPath("//p[@class='card-text']"));

        public ModelPage(DriverContext driverContext)
        {
            _driverContext = driverContext;
        }

        public void Vote()
        {
            CommentBox.SendKeys(Faker.Country.Name());
            VoteButton.Click();
        }
    }
}
