using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_unit_test.PageObjects
{
    partial class LoginPage
    {
     
        private IWebDriver driver;
        private WebDriverWait _driverWait;
		
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            _driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void AuthenticateUser(string user, string password)
        {
            EmailFieldTextBox.SendKeys(user);
            PasswordFieldTextBox.SendKeys(password);
            SubmitButton.Click();
        }

        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);
        }

        public void VerifyElementContainsText(IWebElement elementToVerify, string text)
        {
            Assert.IsTrue(elementToVerify.Text.Contains(text));
        }

    }
}

