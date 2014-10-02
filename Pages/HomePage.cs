using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using SeleniumCamp.Core;

namespace SeleniumCamp.Pages
{
    
public class HomePage:BaseObject
    {
        [FindsBy(How = How.CssSelector, Using = HOME_BTN)]
        public IWebElement homeBtn;

      
        [FindsBy(How = How.CssSelector, Using = SCROLL_BTN)]
        public IWebElement scrollBtn;

        [FindsBy(How = How.CssSelector, Using = SECURITY_BTN)]
        public IWebElement securityBtn;



        public HomePage GetHomePage(IWebDriver driver)
        {
            HomePage homePage = new HomePage();
            InitPage(driver, homePage);
            return homePage;
        }

      
        public const string HOME_BTN =  "a[href='/']";
        public const string INNER_BTN =  "a[href='/inner']";
        public const string SCROLL_BTN = "a[href='/scroll']";
        public const string SECURITY_BTN = "a[href='/security']";
          


    }
}

