using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_unit_test.PageObjects
{
    partial class UserPage
    {
        private IWebDriver driver;

        public UserPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void EditUser()
        {
            Edit.Click();
        }
        public void UpdateUser()
        {
            SubmitButton.Click();
        }
    }
}
