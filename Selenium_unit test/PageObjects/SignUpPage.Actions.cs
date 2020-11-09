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
        private  IWebDriver driver;

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal void CreateAccount(string nume, string email, string telefon, string adresa, string password)
        {
            NumeField.Click();
            NumeField.SendKeys(nume);
            EmailField.SendKeys(email);
            TelefonField.SendKeys(telefon);
            AdresaField.SendKeys(adresa);
            ParolaField.SendKeys(password);
            RepetaParolaField.SendKeys(password);
            SignUpButton.Click();
        }
        public void FillEmailField(string email)
        {
            EmailField.Clear();
            EmailField.SendKeys(email);
        }

    }
}