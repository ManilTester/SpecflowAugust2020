using August2020.Helpers;
using August2020.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace August2020.StepDefinitions
{
    [Binding]
    public sealed class TurnUpStepDefinition
    {
        private LoginPage _loginPage;

        public TurnUpStepDefinition(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
        }

        [Given(@"I login into the TurnUp Portal")]
        public void GivenILoginIntoTheTurnUpPortal()
        {
            _loginPage.LoginSteps();
        }

        [When(@"I click the ""(.*)"" under Admin Drop down on the Main Page")]
        public void WhenIClickTheUnderAdminDropOnTheMainPage(string adminOption)
        {
        }

        [Then(@"I verify that I am on the Employee Page")]
        public void ThenIVerifyThatIAmOnTheEmployeePage()
        {
        }

    }
}
