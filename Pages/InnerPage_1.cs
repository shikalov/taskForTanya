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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using SeleniumCamp.Core;

namespace SeleniumCamp.Pages
{
    
public class InnerPage:HomePage
    {

        [FindsBy(How = How.CssSelector, Using = FORM1)]
         public IWebElement for1;

        [FindsBy(How = How.CssSelector, Using = FORM2)]
        public IWebElement for2;

        [FindsBy(How = How.CssSelector, Using = FORM3)]
        public IWebElement for3;

        [FindsBy(How = How.CssSelector, Using = ADDITIONAL_TEXT)]
        public IWebElement additionalText;

        [FindsBy(How = How.CssSelector, Using = ADDITIONAL_INFORMATION)]
        public IWebElement additionalInformation;

        [FindsBy(How = How.CssSelector, Using = UPLOAD_FILE_BTN)]
        public IWebElement uploadFilesBtn;

        [FindsBy(How = How.CssSelector, Using = USER_NAME)]
        public IWebElement userName;

        [FindsBy(How = How.CssSelector, Using = EMAIL)]
        public IWebElement email;


        public InnerPage GetInnerPage(IWebDriver driver)
        {
            InnerPage innerPage = new InnerPage();
            InitPage(driver, innerPage);
            return innerPage;
        }


        public const string FORM1 = "a[ui-sref='FirstForm']";
        public const string FORM2 = "a[ui-sref='SecondForm']";
        public const string FORM3 = "a[ui-sref='ThirdForm']";
        public const string ADDITIONAL_TEXT = "#prependedcheckbox";
        public const string ADDITIONAL_INFORMATION = "#prependedtext";
        public const string UPLOAD_FILE_BTN = "#filebutton";
        public const string USER_NAME = "#textinput1";
        public const string EMAIL = "#textinput2";
   
    }
}

