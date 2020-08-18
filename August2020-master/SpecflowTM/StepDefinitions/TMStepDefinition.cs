using OpenQA.Selenium;
using SpecflowTM.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTM.StepDefinitions
{
    [Binding]
    public sealed class TMStepDefinition
    {
        private LoginPage loginPage;

        public TMStepDefinition(IWebDriver driver)
        {
            loginPage = new LoginPage(driver);

        }

        [Given(@"I navigate to the TurnUp Portal")]
        public void GivenINavigateToTheTurnUpPortal()
        {
            var url = "http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f";

            loginPage.Navigate(url);
        }

        [When(@"I login to the TurnUp Portal")]
        public void WhenILoginToTheTurnUpPortal()
        {
            loginPage.Login();
        }

        [When(@"I click option ""(.*)"" under Administration Drop Down on the Main Page")]
        public void WhenIClickOptionUnderAdministrationDropDownOnTheMainPage(string option)
        {
            // mainPage.ClickDropDownOption(option);
        }

        [Then(@"I verify I am on the TurnUp Portal")]
        public void ThenIVerifyIAmOnTheTurnUpPortal()
        {
        }


    }
}
