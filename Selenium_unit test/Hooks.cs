using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_unit_test
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }

    //[Binding]  //altfel creeaza 2 instante de browser
    public class Hooks
    {
        private BrowserType _browserType;
        protected IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            //Driver = new ChromeDriver();//creeaza o noua instanta din Chromedriver
            // Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3); 
            // setam driverul sa stea cate o secunda pentru fiecere element acolo unde e folosit
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
            ChooseDriverInstance(_browserType);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");


        }

        public void ChooseDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver();
                    break;
            }
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
        public void NavigateToUrl(string pageUrl)
        {
            Driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
