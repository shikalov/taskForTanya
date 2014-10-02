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

namespace SeleniumCamp.Helper
{
    
    public class Helper:BaseTest
    {
        public static void scrollDownRight(IWebDriver a)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)a;
          //  js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            js.ExecuteScript("scrollBy(9000, 9000)");
       }

        static void navigateToTheUrlViaJs(IWebDriver driver, string url)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteAsyncScript("(function(){window.location.href='"+url+"'; return true;})()");
            }
            catch
            { }
        }



         public static void setcredentials(IWebDriver driver, string url)
        {

            Thread myThread = new Thread(() => navigateToTheUrlViaJs(driver, url)); //Создаем новый объект потока (Thread)

            myThread.Start(); //запускаем поток
                Thread.Sleep(1000);

                System.Windows.Forms.SendKeys.SendWait("user");
                Thread.Sleep(100);
                System.Windows.Forms.SendKeys.SendWait("{TAB}");
                Thread.Sleep(100);
                System.Windows.Forms.SendKeys.SendWait("pass");
                Thread.Sleep(100);

                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                Thread.Sleep(5000);
           
                //    driver.Close();

            
        }




    }
}
