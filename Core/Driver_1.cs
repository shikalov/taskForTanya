using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace SeleniumCamp.Core
{
    public class Driver
    {
        private static IWebDriver driverInstance;

        private Driver()
        {
          
        }

        public static IWebDriver DriverInstance
        {
            get
            {
                if (driverInstance == null)
                {
                  
                    string driver = ConfigurationManager.AppSettings["DefaultDriver"];
                    switch (driver)
                    {
                        case "FF":
                            driverInstance = new ChromeDriver(ConfigurationManager.AppSettings["FFDriverPath"]);
                            break;
                        case "IE":
                            driverInstance = new ChromeDriver(ConfigurationManager.AppSettings["IEDriverPath"]);
                            break;
                        default:
                            driverInstance = new ChromeDriver(ConfigurationManager.AppSettings["ChromeDriverPath"]);
                            break;
                    }
                  
                }
                return driverInstance;
            }
        }

        public static void Close()
        {
            if (driverInstance != null)
            {
                /*driverInstance.Quit();
                driverInstance = null;
*/

            }
        }
    }
}
