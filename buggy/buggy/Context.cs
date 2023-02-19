using BuggyCars.Pages;
using TechTalk.SpecFlow;

namespace BuggyCars
{
    public class Context
    {
        private readonly DriverContext _driverContext;

        public LoginPage LoginPage;
        public RegisterPage RegisterPage;
        public ProfilePage ProfilePage;
        public OverallPage OverallPage;
        public ModelPage ModelPage;

        public Context(DriverContext driverContext) 
        {
            _driverContext = driverContext;

            this.RegisterPage = new RegisterPage(_driverContext);
            this.LoginPage = new LoginPage(_driverContext);
            this.ProfilePage = new ProfilePage(_driverContext);
            this.OverallPage = new OverallPage(_driverContext);
            this.ModelPage = new ModelPage(_driverContext);
        }
    }
}
