using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowTM.PageObjects
{
   public abstract class BasePage
    {
        private readonly IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        /// <summary>
        /// Used for Navigation to different pages
        /// </summary>
        /// <param name="url"> Website Url Example : www.google.com </param>
        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
