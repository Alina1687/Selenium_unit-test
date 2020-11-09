using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Selenium_unit_test.PageObjects;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Selenium_unit_test
{
    [TestFixture]
    public class Tests:Hooks
    {
        [Test, Category("Login")]
        public void ValidateLoginIntoApplicationWithValidCredentials ()
        {
            //Arrange
            NavigateToUrl("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            Thread.Sleep(1000);

            //Act

            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            Thread.Sleep(1000);

            //Assert
            //  Assert.IsTrue(homePage.DeconectareButton.Displayed);
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
            Assert.IsTrue(homePage.DeconectareButton.Displayed);
            Thread.Sleep(1000);
        }
        [Test]
            public void MySecondTest()
        {
            Thread.Sleep(1000);
        }
        [Test]
        public void MyThirdTest()
        {
            Thread.Sleep(1000);
        }
    }

    
}
