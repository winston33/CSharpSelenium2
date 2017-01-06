using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using NUnit.Framework;
using System.Drawing;
using Project.Pages;
using OpenQA.Selenium.Support.PageObjects;


namespace Tests
{
    [TestFixture]
    class TestGmail:BaseTest
    {
        
        [SetUp]
        public void SetupTest()
        {
            Driver = new PhantomJSDriver();
            
        }

        [Test]
        public void Test_GmailLogin()
        {
            Driver.Navigate().GoToUrl("http://mail.google.com");
            GmailHomePage GmailPage = new GmailHomePage(Driver);

            
            /*try
            {
                
                PageFactory.InitElements(Driver, GmailPage);
                GmailPage.LoginUser("abc@gmail.com", "abcd");
                

            }
            catch (Exception e)
            {
                System.Console.WriteLine("LoginUnsuccesful");
                GmailPage.takescreenshot("LoginSuccesfulorNot.gif");
                throw e;
            }*/


        }

        [Test]
        public void Test_GmailLoginScreen()
        {
            Driver.Navigate().GoToUrl("http://mail.google.com");
            GmailHomePage GmailPage = new GmailHomePage(Driver);
            if (!"Gogle".Equals(Driver.Title))
            {
                string msg = "Page with title Gogle is not found";
                GmailPage.takescreenshot("gogle.gif");
                throw new NoSuchWindowException(msg);

            }
        }

        [TearDown]
        public void Teardown()
        {

            //Step e
            Driver.Quit();
        }
    }
}
