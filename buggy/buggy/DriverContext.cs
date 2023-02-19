using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BuggyCars
{
    public class DriverContext
    {
        public IWebDriver driver;

        public DriverContext()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
