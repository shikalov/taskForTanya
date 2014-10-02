using System;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumCamp.Core;
using SeleniumCamp.Pages;
using System.Threading;


namespace SeleniumCamp.Steps
{

    class Steps:BaseTest
    {
        public static void VisitPage(IWebDriver driverInstance, string url)
        {
            driverInstance.Navigate().GoToUrl(url);         
        }


        public static void ClickBtn(IWebElement btn)
        {
            btn.Click();
            Thread.Sleep(5000);
        }


        public static void FillField(IWebElement el, string value)
        {
            el.SendKeys(value);
            Thread.Sleep(5000);
        }

        public static string GetFieldsValue(IWebElement el)
        {
            string value="";
            Thread.Sleep(5000);
            return value;   
        }

    }

}
