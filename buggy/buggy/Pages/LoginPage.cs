using BuggyCars.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCars.Pages
{
    public class LoginPage
    {
        private readonly DriverContext _driverContext;
        public IWebElement UsernameField => _driverContext.driver.FindElement(By.Name("login"));
        public IWebElement PasswordField => _driverContext.driver.FindElement(By.Name("password"));
        public IWebElement LoginButton => _driverContext.driver.FindElement(By.XPath("//button[@type='submit'][text()='Login']"));
        public IWebElement RegisterButton => _driverContext.driver.FindElement(By.XPath("//button[text()='Register']"));
        public IWebElement LogoutButton => _driverContext.driver.FindElement(By.XPath("//a[@class='nav-link'][text()='Logout']"));
        public IWebElement UnsuccessfulLoginError => _driverContext.driver.FindElement(By.XPath("//span[contains(text(), 'Invalid username/password')]"));
        public IWebElement LoginSuccessfulMessage => _driverContext.driver.FindElement(By.XPath("//span[contains(text(),'Hi, ')]"));

        public LoginPage(DriverContext driverContext)
        { 
            _driverContext = driverContext;
        }

        public void EnterCredentialsAndSubmit(string user, string password)
        {
            UsernameField.SendKeys(user);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }

        public void ClickRegisterButton() => RegisterButton.Click();

        public bool UnsuccessfulLoginErrorDisplayed() => UnsuccessfulLoginError.Displayed;
    }
}
