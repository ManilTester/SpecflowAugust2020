using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace August2020.Hooks
{
    [Binding]
    public sealed class Hooks
    {

        // IOC Container

        private readonly IObjectContainer _objectContainer;

        private IWebDriver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "TestResults"));
        }

        [BeforeScenario(Order = 0)]
        public void BeforeScenario()
        {
            GetDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver?.Dispose();
        }

        /// <summary>
        /// Create and initialize driver
        /// </summary>
        /// <returns></returns>

        public IWebDriver GetDriver()
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
    }
}
