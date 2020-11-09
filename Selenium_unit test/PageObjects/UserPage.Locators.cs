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
     
        private IWebElement Edit => driver.FindElement(By.ClassName("fa-pencil"));
        public IWebElement SubmitButton => driver.FindElement(By.ClassName("btn-primary"));

    }
}

