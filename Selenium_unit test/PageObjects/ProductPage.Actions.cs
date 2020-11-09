using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_unit_test.PageObjects
{
    partial class ProductPage
    {
 
        private IWebDriver driver;
        private WebDriverWait _driverWait;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            _driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public void AddCos()
        {
            AdaugaProdusInCosButton.Click();
        }

    }
}
