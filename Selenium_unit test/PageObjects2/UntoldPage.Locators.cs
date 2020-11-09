using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_unit_test.PageObjects2
{
    partial class UntoldPage
    {
        private IWebDriver driver;
        private WebDriverWait driverWait;

        public UntoldPage(IWebDriver driver)
        {
            this.driver = driver;
           this.driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            this.driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        private IWebElement Frame => driver.FindElement(By.CssSelector("iframe"));

        private IWebElement AgreeButton => driver.FindElement(By.Id("introAgreeButton"));
        public IWebElement HomeMenuItem => driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='HOME']")));

        public IWebElement UntoldRadio =>driverWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("styles-module--top--31tR1")));
        public IWebElement MenuButton => driver.FindElement(By.CssSelector(".bm-burger-button button"));
    }
}