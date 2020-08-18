using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace August2020.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        // steps to login to TurnUp portal
        public void LoginSteps()
        {

            // launch TurnUp portal
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // Maximize the browser
           // driver.Manage().Window.Maximize();

            // Find Username textbox and input username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // Find Password textbox and input password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // Find login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();


            // Find hello hari hyperlink
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));


            // Option 2 - Validate if the text on the hyperlink is hello Hari
            if (helloHari.Text == "Hello hari!")
            {
                Assert.Pass("Logged In successfully, test passed");
            }
            else
            {
                Assert.Fail("Login failed, test failed");
            }

            // Option 1 - Validate if the text on the hyperlink is hello Hari
            Assert.That(helloHari.Text, Is.EqualTo("Hello hari!"));

        }
    }
}
