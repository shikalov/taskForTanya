using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumCamp.Core;
using SeleniumCamp.Pages;
using System.Threading;
using SeleniumCamp.Helpers;
using System.Configuration;


namespace SeleniumCamp.StepsDescription
{

    public class Steps
    {
        private InnerPage _page;
        public Steps(InnerPage page)
        {
            _page = page;
        }
        public void IClickInnerPage()
        {
            _page.innerBtn.Click();
        }

        public void INavigateToUplForm()
        {
            Thread.Sleep(3000);
            _page.for3.Click();
        }

        public void IClickBrowseBtn()
        {
            Thread.Sleep(3000);
            _page.uploadFilesBtn.Click();
        }
        

        public static string GetFieldsValue(IWebDriver driverInstance, string value)
        {
            return Helper.GetFieldValue(driverInstance, value);
        }

        public static void FillCredentialsAndLogIn(IWebDriver driver, string url)
        {
            Helper.setcredentials(driver, url, ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);

        }

        public static void WaitForLoading(IWebDriver driver)
        {
            Helper.WaitForAngular(driver);
        }


    }

}
