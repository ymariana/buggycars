using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BuggyCars.Pages
{
    public class RegisterPage
    {
        private readonly DriverContext _driverContext;
        public IWebElement LoginField => _driverContext.driver.FindElement(By.Id("username"));
        public IWebElement FirstNameField => _driverContext.driver.FindElement(By.Id("firstName"));
        public IWebElement LastNameField => _driverContext.driver.FindElement(By.Id("lastName"));
        public IWebElement PasswordField => _driverContext.driver.FindElement(By.Id("password"));
        public IWebElement ConfirmPasswordField => _driverContext.driver.FindElement(By.Id("confirmPassword"));
        public IWebElement RegisterButton => _driverContext.driver.FindElement(By.XPath("//button[@type='submit'][text()='Register']"));
        public IWebElement CancelButton => _driverContext.driver.FindElement(By.XPath("//button[@role='button'][text()='Cancel']"));
        public IWebElement RegistrationSuccessMessage => _driverContext.driver.FindElement(By.XPath("//div[contains(text(),'Registration is successful')]"));


        public RegisterPage(DriverContext driverContext) 
        {
            _driverContext = driverContext;
        }


        public void EnterData(string login, string password)
        {
            LoginField.SendKeys(login);
            FirstNameField.SendKeys(Faker.Name.First());
            LastNameField.SendKeys(Faker.Name.Last());
            PasswordField.SendKeys(password);
            ConfirmPasswordField.SendKeys(password);
        }

        public bool SuccessfulMessageDisplayed() => RegistrationSuccessMessage.Displayed;

        public void ClickRegisterButton() => RegisterButton.Click();

        public void ClickCancelButton() => CancelButton.Click();

    }
}
