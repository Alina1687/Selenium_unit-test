using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_unit_test.PageObjects
{
    partial class SignUpPage
    {
        public IWebElement NumeField => driver.FindElement(By.XPath("//input[@name='name']"));
        public IWebElement EmailField => driver.FindElement(By.XPath("//input[@name='email']"));
        public IWebElement TelefonField => driver.FindElement(By.XPath("//input[@name='phone']"));
        public IWebElement AdresaField => driver.FindElement(By.XPath("//textarea[@name='address']"));
        public IWebElement ParolaField => driver.FindElement(By.XPath("//input[@name='password_1']"));
        public IWebElement RepetaParolaField => driver.FindElement(By.XPath("//input[@name='password_2']"));
        public IWebElement SignUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));
    }
}
