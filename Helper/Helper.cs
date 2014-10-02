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
using SeleniumCamp.Core;
using System.Threading;


namespace SeleniumCamp.Helpers
{
    
    public static class Helper
    {
        public static void scrollDownRight(IWebDriver a)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)a;
            js.ExecuteScript("scrollBy(9000, 9000)");
       }


        public static string GetFieldValue(IWebDriver driver, string xpath)
        {
           IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
           string script = "return document.evaluate(\"" + xpath + "\", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.value;";
           string value = js.ExecuteScript(script).ToString();
           return value;
        }

    
        static void navigateToTheUrlViaJs(IWebDriver driver, string url)
        {
            try
            {  
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteAsyncScript("window.location.href='"+url+"'; return true;");
            }
            catch
            { }
        }


        public static void setcredentials(IWebDriver driver, string url, string userName, string password)
        {
                Thread myThread = new Thread(() => navigateToTheUrlViaJs(driver, url)); 
                myThread.Start();
                Thread.Sleep(1000);
                System.Windows.Forms.SendKeys.SendWait(userName);
                Thread.Sleep(100);
                System.Windows.Forms.SendKeys.SendWait("{TAB}");
                Thread.Sleep(100);
                System.Windows.Forms.SendKeys.SendWait(password);
                Thread.Sleep(100);
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                Thread.Sleep(5000);
        }

        public static void WaitForAngular(IWebDriver driver)
        {
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
           
            string script1 = "angular.element([$('body')]).injector().get('$http').pendingRequests.length";
            string script2 = "$.active";
            bool flag = true;
            
            var a1 = (Convert.ToInt32(js.ExecuteScript(script1)));
            var a2 = (Convert.ToInt32(js.ExecuteScript(script2)));

            while (flag)
            {
                flag = !(Convert.ToInt32(js.ExecuteScript(script1)) == 0 && Convert.ToInt32(js.ExecuteScript(script2)) == 0);
                Thread.Sleep(100);          
            }
           
            
        }
                
    }
}
