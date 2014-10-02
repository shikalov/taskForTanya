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
    public class Tests : BaseTest
    {
       private InnerPage page;
      
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
                            .And(SuccessfullyAuthorized)
                  .Execute();

       }
    

       [TestMethod]
       public void uploadfiles()
       {
           page = new InnerPage().GetInnerPage(driverInstance);
           var steps = new Steps(page);

           new Story("Selenium cggamp")
               .InOrderTo("Benefit")
               .AsA("Role")
               .IWant("Test uploading new files and inner scrolling")

                           .WithScenario("Upload files")
                           .Given(IAmOnTheHomePage, "http://91.234.37.131:4000/")
                           .And(steps.IClickInnerPage)
                           .And(steps.INavigateToUplForm)
                           .And(steps.IClickBrowseBtn)
                           //.And(IUploadNewFiles)
                           //.And(IDoInnerScrolling)
                  .Execute();
       }

        
       private void IAmOnTheHomePage(string url)
        {
          //  page = new InnerPage().GetInnerPage(driverInstance);
            driverInstance.Navigate().GoToUrl(url);
         
        }

    
       private void IFillCredentialsAndLogIn()
       {
           Steps.FillCredentialsAndLogIn(driverInstance, "http://91.234.37.131:4000/security");
       }
    

       private void SuccessfullyAuthorized()
       {
           Assert.IsTrue(driverInstance.PageSource.Contains("Authorization passed"), "Authorization failed");
       }   

            
    }

}
