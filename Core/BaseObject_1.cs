using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;

namespace SeleniumCamp.Core
{

    public class BaseObject 
    {
 
        public static void InitPage<T>(IWebDriver driver,T pageClass) where T : BaseObject
        {  
            PageFactory.InitElements(driver, pageClass);
        }
    }

}

