using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Selenium_unit_test.PageObjects;
using Selenium_unit_test.PageObjects2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.PageObjects_2;
using Assert = NUnit.Framework.Assert;

namespace Selenium_unit_test
{
  partial  class Test_Google_Untold_Teatru:Hooks
    {
        [Test]
        //EX_tema:Navigati pe https://www.google.com/. Scrieti in campul de search “paris” si apasati pe butonul Google Search. 
        //Selectati “Images” din optiuni. Selectati prima imagine gasita.  Dati Back catre pagina cu imagini.
        public void GoogleSearch()
        {
            //Arrange
            NavigateToUrl("https://www.google.com/");
            GooglePage googlePage = new GooglePage(Driver);
            googlePage.AcceptTerms();

            //Act 
            googlePage.GoogleSearch("paris");
            googlePage.ClickResultFromImages();
            //Assert 
            Assert.IsTrue(googlePage.PanelDisplayed());

            //Act 
            googlePage.BackToImages();
            //Assert 
            Assert.IsFalse(googlePage.PanelDisplayed());
        }
        [Test]
        //Navigati catre pagina https://untold.com/. Dati click pe meniu si selectati pagina HOME.
        public void Untold()
        {
            //Arrange
            NavigateToUrl("https://untold.com/");
            UntoldPage untoldPage = new UntoldPage(Driver);


          //  untoldPage.UntoldRadio.Displayed();  
            untoldPage.MenuButton.Click();
            untoldPage.HomeMenuItem.Click();

            //Assert
            Assert.AreEqual("https://untold.com/", Driver.Url);
        }

        [Test]
        //Navigati catre pagina https://www.teatrulsicaalexandrescu.ro/?lang=en. 
        //Dati click pe Team(engleza) si selectati prima persoana din echipa. Dati click pe primul spectacol al persoanei respective.
        public void Teatru()
        {
            //Arrange
            NavigateToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");

            //Act
            TeatruPage teatruPage = new TeatruPage(Driver);
            teatruPage.Menu.Click();
           //teatruPage.    (Driver, teatruPage.Actor1);
           // teatruPage.    (Driver, teatruPage.Show1);
           
            //Assert
            Assert.IsTrue(teatruPage.CumparaButton.Displayed);
        }
    }
}

