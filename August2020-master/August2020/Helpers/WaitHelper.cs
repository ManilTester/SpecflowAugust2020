using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace August2020.Helpers
{
    class WaitHelper
    {
        // generic function to wait for an element to be clickable
        public static void WaitClickable(IWebDriver driver, string attribute, string value, int seconds)
        {
            //try
            //{
            //    if (attribute == "Id")
            //    {
            //        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            //        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(value)));
            //    }
            //    if (attribute == "XPath")
            //    {
            //        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            //        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(value)));
            //    }
            //    if (attribute == "CSSSelector")
            //    {
            //        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            //        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(value)));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Assert.Fail("Unable to click web element", ex.Message);
            //}

        }

        // generic function to wait for an element to exist
        public static void WaitExists(IWebDriver driver, string attribute, string value, int seconds)
        {
            //try
            //{
            //    if (attribute == "Id")
            //    {
            //        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            //        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(value)));
            //    }
            //    if (attribute == "XPath")
            //    {
            //        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            //        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(value)));
            //    }
            //    if (attribute == "CSSSelector")
            //    {
            //        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            //        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(value)));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Assert.Fail("Unable to locate the webelement", ex.Message);
            //}

        }
    }
}
