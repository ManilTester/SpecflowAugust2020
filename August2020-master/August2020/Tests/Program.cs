using August2020.Helpers;
using August2020.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace August2020
{
    [TestFixture]
    [Parallelizable]
    class Program : CommonDriver
    {
     
        //[Test, Description("Check if the user is able to create TM with valid data")]
        //public void CreateTM_Test()
        //{
        //    // Home page object init and definition
        //    HomePage homeObj = new HomePage();
        //    homeObj.NavigateToTM();

        //    // TM page object init and definition
        //    TMPage tmObj = new TMPage();
        //    tmObj.CreateTM(driver);
        //}

        //[Test, Description("Check if the user is able to edit TM with valid data")]
        //public void EditTM_Test()
        //{
        //    // Home page object init and definition
        //    HomePage homeObj = new HomePage();
        //    homeObj.NavigateToTM(driver);

        //    // TM page object init and definition
        //    TMPage tmObj = new TMPage();
        //    // Edit existing TM test
        //    tmObj.EditTM(driver);
        //}

        //[Test, Description("Check if the user is able to delete TM with valid data")]
        //public void DeleteTM_Test()
        //{
        //    // Home page object init and definition
        //    HomePage homeObj = new HomePage();
        //    homeObj.NavigateToTM(driver);

        //    // TM page object init and definition
        //    TMPage tmObj = new TMPage();
        //    // Edit existing TM test
        //    tmObj.DeleteTM(driver);
        //}

    }
}
