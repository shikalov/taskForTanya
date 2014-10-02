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
using SeleniumCamp.Helper;
using SeleniumCamp.Pages;
using SeleniumCamp.Steps;
using StoryQ;
using System.Threading;


namespace SeleniumCamp.Test
{
    [TestClass]
    public class StoryQTestClass : BaseTest
    {
       private InnerPage page;
      
       [TestMethod]
       public void scrolling()
       {
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
       public void basic_auth_windows()
       {           
           new Story("Basic authorization window")
               .InOrderTo("Benefit")
               .AsA("Role")
               .IWant("Test basic authorization window")
                            .WithScenario("Basic authorization windows")
                           .Given(IAmOnTheHomePage, "http://91.234.37.131:4000/")
                            .And(IFillCredentialsAndLogIn)
                            //.And(SuccessfullyAuthorized)
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
                            .And(FIeldsValuesAre_, "Alex", "trololo@trololo.ru")
                  .Execute();
       }


       [TestMethod]
       public void uploadfilesAndScroll()
       {
           new Story("Selenium cggamp")
               .InOrderTo("Benefit")
               .AsA("Role")
               .IWant("Test uploading new files and inner scrolling")

                           .WithScenario("Upload files")
                           .Given(IAmOnTheHomePage, "http://91.234.37.131:4000/")
                           .And(IClickInnerPage)
                           .And(INavigateToUplForm)
                           .And(IClickBrowseBtn)
                           //.And(IUploadNewFiles)
                           //.And(IDoInnerScrolling)
                  .Execute();
       }

        
       private void IAmOnTheHomePage(string url)
        {
            page = new InnerPage().GetInnerPage(driverInstance);
            Steps.Steps.VisitPage(driverInstance, url);
        }

       private void IFillUsernameWith_(string name)
       {
           Steps.Steps.FillField(page.userName, name); 
       }

       private void IFillEmailWith_(string email)
       {
           Steps.Steps.FillField(page.email, email);
       }

       private void INavigateToFieldsPage()
       {
             Steps.Steps.ClickBtn(page.for2);
       }

       private void IClickInnerPage()
       {
             Steps.Steps.ClickBtn(page.innerBtn);
       }

       private void IClickSecurityPage()
       {
             Steps.Steps.ClickBtn(page.securityBtn);
       }

       private void IFillCredentialsAndLogIn()
       {
           Helper.Helper.setcredentials(driverInstance, "http://91.234.37.131:4000/security");
       }

       private void IClickScrollingPage()
       {
           Steps.Steps.ClickBtn(page.scrollBtn);
       }

       private void INavigateToUplForm()
       {
           Steps.Steps.ClickBtn(page.for3);
       }

       private void IClickBrowseBtn()
       {
           Steps.Steps.ClickBtn(page.uploadFilesBtn);
       }

       private void IScrolllgPageDownAndRightLeft()
       {
           Helper.Helper.scrollDownRight(driverInstance);
           Thread.Sleep(10000);
       }




        //not realised
       private void FIeldsValuesAre_(string name, string email)
       {
           Steps.Steps.GetFieldsValue(page.additionalText);
       }


        
    
    
    }

}
