using August2020.Helpers;
using August2020.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace August2020.Tests
{
    [TestFixture]
    [Parallelizable]
    class EmployeeTests : CommonDriver
    {

        //[Test, Description("Check if the user is able to create employee with valid data")]
        //public void CreateEmployee_Test()
        //{
        //    // Home page object init and definition
        //    HomePage homeObj = new HomePage();
        //    homeObj.NavigateToEmployee(driver);

        //    // Employee page object init and definition
        //    EmployeesPage employeeObj = new EmployeesPage();
        //    employeeObj.CreateEmployee(driver);
        //}

        //[Test, Description("Check if the user is able to edit employee with valid data")]
        //public void EditEmployee_Test()
        //{
        //    // Home page object init and definition
        //    HomePage homeObj = new HomePage();
        //    homeObj.NavigateToEmployee(driver);

        //    // Employee page object init and definition
        //    EmployeesPage employeeObj = new EmployeesPage();
        //    employeeObj.EditEmployee(driver);
        //}

        //[Test, Description("Check if the user is able to delete employee")]
        //public void DeleteEmployee_Test()
        //{
        //    // Home page object init and definition
        //    HomePage homeObj = new HomePage();
        //    homeObj.NavigateToEmployee(driver);

        //    // Employee page object init and definition
        //    EmployeesPage employeeObj = new EmployeesPage();
        //    employeeObj.DeleteEmployee(driver);
        //}

    }
}
