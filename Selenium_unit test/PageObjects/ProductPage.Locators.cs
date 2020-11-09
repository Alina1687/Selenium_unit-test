using OpenQA.Selenium;
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
        private IWebElement AdaugaProdusInCosButton => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".btn-primary")));
    }
}
