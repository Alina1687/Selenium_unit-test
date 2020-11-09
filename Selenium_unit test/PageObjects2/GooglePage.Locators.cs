using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.PageObjects_2
{
    partial class GooglePage
    {
        private readonly IWebDriver driver;
        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }
       
        private IWebElement Frame => driver.FindElement(By.CssSelector("iframe"));

        private IWebElement AgreeButton => driver.FindElement(By.Id("introAgreeButton"));
        private IWebElement SearchTextBox => driver.FindElement(By.CssSelector(".gLFyf.gsfi"));
        private IWebElement GoogleSearchButton => driver.FindElement(By.ClassName("gNO89b"));
   
        private IWebElement ImagesLink => driver.FindElement(By.CssSelector(".hdtb-mitem.hdtb-imb a"));
        private IWebElement Image1 => driver.FindElement(By.XPath("//div[1]/a[@jsname='sTFXNd']"));
        private IWebElement BackToIcon => driver.FindElement(By.ClassName("IA8gLe"));
        private IWebElement Panel => driver.FindElement(By.Id("islsp"));
    }
}