using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace SeleniumCamp.Core
{
    public class Driver
    {
        private IWebDriver driverInstance;
        //private static object _lock;
        
        public IWebDriver DriverInstance
        {
            get
            {
                if (driverInstance == null)
                {
                    string driver = ConfigurationManager.AppSettings["DefaultDriver"];
                    switch (driver)
                    {
                        case "IE":
                            driverInstance = new InternetExplorerDriver(ConfigurationManager.AppSettings["IEDriverPath"]);
                            break;
                        default:
                            driverInstance = new ChromeDriver(ConfigurationManager.AppSettings["ChromeDriverPath"]);
                            break;
                    }
                }
                else
                { 
                }
    
                return driverInstance;
            }
        }
    }
}
