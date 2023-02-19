using OpenQA.Selenium;
using static Faker.Finance.Credit;

namespace BuggyCars.Pages
{
    public class OverallPage
    {
        private readonly DriverContext _driverContext;

        public IWebElement FirstModel => _driverContext.driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3) > a"));

        public IWebElement BuggyRatingLogo => _driverContext.driver.FindElement(By.XPath("//a[@class='navbar-brand']"));

        public OverallPage(DriverContext driverContext)
        {
            _driverContext = driverContext;
        }

        public void NavigateToFirstModel()
        {
            FirstModel.Click();
        }
    }
}
