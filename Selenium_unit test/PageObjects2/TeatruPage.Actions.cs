using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_unit_test.PageObjects
{
    partial class TeatruPage
    {
        private IWebDriver driver;
        public TeatruPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectMenu()
        {
            Menu.Click();
        }
        public void AddBilet()
        {
            CumparaButton.Click();
        }
        public void scrollUp()
        {
            IWebElement s = driver.FindElement(By.Id("Actor1")); ;
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", s);
            Show1.Click() ;
        }
    }
}