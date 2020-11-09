using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace Selenium_unit_test.PageObjects
{
    partial class LoginPage
    {
    //private IWebElement EmailFieldTextBox =>_driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type=email]")));
    private IWebElement EmailFieldTextBox => driver.FindElement(By.XPath("//input[@type='email']"));
    // private IWebElement EmailDropDown => driver.FindElement(By.CssSelector("input'type=email]"));
    //private IWebElement RadioButton => driver.FindElement(By.CssSelector("input[type='email']"));
    private IWebElement PasswordFieldTextBox => driver.FindElement(By.CssSelector("input[type=password]"));
    private IWebElement SubmitButton => driver.FindElement(By.CssSelector("button[type=submit]"));
    public IWebElement AlertMessage => driver.FindElement(By.ClassName("alert"));
    }
}