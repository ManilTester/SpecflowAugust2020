using August2020.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace August2020.Pages
{
    class TMPage
    {
        // function to create new TM
        public void CreateTM(IWebDriver driver)
        {

            // Click new button
            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='container']/p/a", 5);
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            try
            {
                // Select a type code from the drop down list
                driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Create new TM page did not launch", ex.Message);
            }
           

            // Input a code value
            driver.FindElement(By.Id("Code")).SendKeys("August2020");
            Thread.Sleep(1000);

            // Input Description
            driver.FindElement(By.Id("Description")).SendKeys("AugustDescription");

            // Input price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.Id("Price")).SendKeys("123");

            // Click save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);

            // Go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            // Check if the created time/ material is present 
            IWebElement actualCode = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (actualCode.Text == "August2020")
            {
                Console.WriteLine("Time record created successfully, test passed!");
            }
            else
            {
                Console.WriteLine("Time record not created successfully, test failed!");
            }
        }

        // function to edit existing TM
        public void EditTM(IWebDriver driver)
        {
            // Edit time and material test
        }

        // function to delete TM
        public void DeleteTM(IWebDriver driver)
        {
            // Delete time and material test
        }
    }
}
