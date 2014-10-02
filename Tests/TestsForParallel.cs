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
using SeleniumCamp.Helpers;
using SeleniumCamp.Pages;
using SeleniumCamp.StepsDescription;
using StoryQ;
using System.Threading;


namespace SeleniumCamp.Test
{
    [TestClass]
    public class TestsForParallel : BaseTest
    {
        private InnerPage page;

        [TestMethod]
        public void scrolling()
        {
            page = new InnerPage().GetInnerPage(driverInstance);
            var steps = new Steps(page);

            new Story("Selenium Camp")
                .InOrderTo("Benefit")
                .AsA("Role")
                .IWant("Test scrolling")
                            .WithScenario("Testing of scrolling")
                            .Given(IAmOnTheHomePage, "http://91.234.37.131:4000/")
                            .And(IClickScrollingPage)
                            .And(IScrolllgPageDownAndRightLeft)
                   .Execute();
        }



        [TestMethod]
        public void fields()
        {
            new Story("Selenium camp")
                .InOrderTo("Benefit")
                .AsA("Role")
                .IWant("Test ability to get field value when it is absent in HTML")

                             .WithScenario("Fields")
                             .Given(IAmOnTheHomePage, "http://91.234.37.131:4000/")
                             .And(IClickInnerPage)
                             .And(INavigateToFieldsPage)
                             .And(IFillUsernameWith_, "Alex")
                             .And(IFillEmailWith_, "trololo@trololo.ru")
                             .And(UserNameValueIs_, "Alex")
                             .And(EmailValueIs_, "trololo@trololo.ru")
                   .Execute();
        }

        private void IAmOnTheHomePage(string url)
        {
            page = new InnerPage().GetInnerPage(driverInstance);
            driverInstance.Navigate().GoToUrl(url);
        }

        private void IFillUsernameWith_(string name)
        {
            Thread.Sleep(3000);
            page.userName.SendKeys(name);            
        }

        private void IFillEmailWith_(string email)
        {
            Thread.Sleep(3000);
            page.email.SendKeys(email);
        }

        private void INavigateToFieldsPage()
        {
            page.for2.Click();
        }

        private void IClickInnerPage()
        {
            page.innerBtn.Click();
        }

        private void IClickScrollingPage()
        {
            page.scrollBtn.Click();
        }

        private void IScrolllgPageDownAndRightLeft()
        {
            Helper.scrollDownRight(driverInstance);
            Thread.Sleep(10000);
        }

        private void UserNameValueIs_(string value)
        {
            Assert.AreEqual(value, Steps.GetFieldsValue(driverInstance, page.UsernameXPATh));
        }

        private void EmailValueIs_(string value)
        {
            Assert.AreEqual(value, Steps.GetFieldsValue(driverInstance, page.EmailXPATh));

        }



    }

}
