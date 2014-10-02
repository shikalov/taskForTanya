using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;



namespace SeleniumCamp.Core
{
     [TestClass()]
    public class BaseTest
    {
        public IWebDriver driverInstance;
  

       [TestCleanup]
        public void Close()
        {
            driverInstance.Manage().Cookies.DeleteAllCookies();
            driverInstance.Close();
            driverInstance.Dispose();
          
        }

       [TestInitialize]
        public void Open()
        {
            driverInstance = Driver.DriverInstance;
         
        }

  
    }
}
