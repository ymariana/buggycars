using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCars.Pages
{
    public class ProfilePage
    {
        private readonly DriverContext _driverContext;

        public IWebElement ProfileButton => _driverContext.driver.FindElement(By.XPath("//a[@class='nav-link'][text()='Profile']"));
        public IWebElement HobbyField => _driverContext.driver.FindElement(By.Id("hobby"));
        public IWebElement AgeField => _driverContext.driver.FindElement(By.Id("age"));
        public IWebElement AddressField => _driverContext.driver.FindElement(By.Id("address"));
        public IWebElement SaveButton => _driverContext.driver.FindElement(By.XPath("//button[@type='submit'][text()='Save']"));
        public IWebElement UpdatedSuccessfulMessage => _driverContext.driver.FindElement(By.XPath("//div[contains(text(),'The profile has been saved successful')]"));


        public ProfilePage(DriverContext driverContext) => _driverContext = driverContext;

        public void ClickProfileButton() => ProfileButton.Click();
        public void ClickSaveButton() => SaveButton.Click();

        public void SelectHobby(string hobby)
        {
            SelectElement selectedHobby = new SelectElement(HobbyField);
            selectedHobby.SelectByText(hobby);
        }
           
    }
}
