using TechTalk.SpecFlow;

namespace BuggyCars.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        private readonly DriverContext _driverContext;

        public Hooks(DriverContext driverContext)
        {
            _driverContext = driverContext;
        }


        [AfterScenario]
        public void AfterScenario()
        {
            _driverContext.driver.Quit();
        }

    }
}
