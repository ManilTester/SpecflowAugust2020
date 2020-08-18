using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTM.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver _driver;

        // IOC Container for Specflow

        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            GetDriver();
        }

        private IWebDriver GetDriver()
        {
            var browser = "Chrome";

            if (_driver == null)
            {
                switch (browser)
                {
                    // TODO : Add support for other drivers. Firefox and Edge

                    case "Chrome":

                        ChromeOptions chromeOptions = new ChromeOptions();

                        // Get value for headless option from appsettings.json

                        var headless = "false";

                        if (headless == "true")
                        {
                            chromeOptions.AddArgument("--headless");
                        }

                        // Solves the problem where you have to provide local driver path example : C://localDir
                        _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);


                        break;
                }

                try
                {
                    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    _driver.Manage().Cookies.DeleteAllCookies();
                    _driver.Manage().Window.Maximize();

                    // Instantiate the driver and Register the container

                    _objectContainer.RegisterInstanceAs(_driver);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message + " Driver failed to initialize");
                }
            }

            return _driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Close();
            _driver.Dispose();
        }


    }
}
