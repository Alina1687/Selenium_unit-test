using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_unit_test.PageObjects
{
        partial class HomePage
        {
            public void GoToAuthentication()
            {
                AutentificareButton.Click();
            }

            public void SignUp()
            {
                InscriereButton.Click();
            }

            public void DeconectareUser()
            {
                DeconectareButton.Click();
            }

            public void VeziDetaliiProdus()
            {
                VeziDetaliiButton.Click();
            }

            public void GoToMenu(string menuName)
            {
                GetMenuElement(menuName).Click();
            }

            public IWebElement GetMenuElement(string menuName)
            {
                return NavBar.FindElement(By.XPath($"//a[contains(text(),'{menuName}')]"));
            }
        }
    }