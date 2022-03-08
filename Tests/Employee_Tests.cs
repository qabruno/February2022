using February2022.Pages;
using February2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
        [Test, Order(1), Description("Check if user is able to create an employee record with valid data")]
        public void CreateEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployPage(driver);

            // Employee page object initialization and definition
            EmployeePage employPageObj = new EmployeePage();
            employPageObj.CreateEmployee(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit an employee record with valid data")]
        public void EditTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployPage(driver);

            // Edit Employee
            EmployeePage employPageObj = new EmployeePage();
            employPageObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete an existing exployee record")]
        public void DeleteTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployPage(driver);

            // Delete Employee
            EmployeePage employPageObj = new EmployeePage();
            employPageObj.DeleteEmployee(driver);
        }
    }
}
