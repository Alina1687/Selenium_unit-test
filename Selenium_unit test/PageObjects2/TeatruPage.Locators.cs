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
        public IWebElement Menu => driver.FindElement(By.XPath("//span[(text()='Team')]"));

        //private IWebElement Actor1 => driver.FindElement(By.XPath("//a[starts-with(@id,'av-masonry-1-item-')][1]"));
        public IWebElement Actor1 => driver.FindElement(By.Id("av-masonry-1-item-2697"));
        public IWebElement Show1 => driver.FindElement(By.XPath("//div/p/a/strong"));
        public IWebElement CumparaButton => driver.FindElement(By.XPath("//span[text()='CUMPARA BILET']"));
    }
}
