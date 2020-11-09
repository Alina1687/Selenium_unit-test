using NUnit.Framework;
using Selenium_unit_test.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_unit_test
{
    [TestFixture]
    //Navigati catre pagina http://demosite.casqad.org/
    class Tests_casqad : Hooks
    {
        private readonly string SiteUrl = "http://demosite.casqad.org/";

        private readonly string UserAdmin = "admin.test3@gmail.com";
        private readonly string PasswordAdmin = "password123";

        private readonly string UserGaby = "gabytest@test.com";
        private readonly string PasswordGaby = "test123";

        [Test]
        //a.	Logati-va in aplicatie.
        public void VerifyLoginWithValidCredentials()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser(UserAdmin, PasswordAdmin);

            //Assert
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
        }

        [Test]
        //b.	Adaugati in cos un produs ca si utilizator.( fara sa fiu logata)
        public void VerifyAddToCartAsGuest()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            ProductPage productPage = new ProductPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);

            //Act
            homePage.VeziDetaliiProdus();
            productPage.AddCos();

            //Assert
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "Pentru a efectua actiunea trebuie sa fiti logat");
        }


        [Test]
        //c.	Adaugati in cos un produs ca si admin.
        public void VerifyAddToCartAsAdmin()
        {
            CartPage cartPage = new CartPage(Driver);
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            ProductPage productPage = new ProductPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser(UserAdmin, PasswordAdmin);

            //Act
            homePage.VeziDetaliiProdus();
            productPage.AddCos();

            //Assert
            loginPage.VerifyElementIsDisplayed(cartPage.ComandaButton);
        }

        [Test]
        //d.	Faceti inscrierea si logati-va cu noul cont.
        public void VerifySignUpAndLoginWithNewUser()
        {
          


            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            SignUpPage signUpPage = new SignUpPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.SignUp();

            //Act 
            signUpPage.CreateAccount(" User", "0743012216", "Strada", "Brasov", "Password");
            //Assert 
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "Your account was created");

            //Act 
            loginPage.AuthenticateUser(UserGaby, PasswordGaby);
            //Assert
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
        }

        [Test]
        //e.	Logati-va si deconectati-va din site.
        public void LoginAndLogout()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();

            //Act 
            loginPage.AuthenticateUser(UserGaby, PasswordGaby);
            //Assert 
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);

            //Act 
            homePage.DeconectareUser();
            //Assert 
            loginPage.VerifyElementIsDisplayed(homePage.AutentificareButton);
        }

        [Test]
        //f.	Da click pe fiecare meniu (orizontal).
        public void VerifyMenuNavigation()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);

            string[] menus = { "Laptopuri", "Telefoane", "Foto", "Carti", "Accesorii" };
            foreach (var menu in menus)
            {
                //Act
                homePage.GoToMenu(menu);
                //Assert
                loginPage.VerifyElementContainsText(homePage.Category, menu);
            }
        }

        [Test]
        //g.	Ca si admin, dati click pe buton de administrare.
        public void VerifyAdministrationSectionAsAdmin()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser(UserAdmin, PasswordAdmin);

            //Act
            homePage.GoToMenu("Administrare");

            //Assert
            loginPage.VerifyElementIsDisplayed(homePage.GetMenuElement("Site"));
        }

        [Test]
        //h.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori.
        public void VerifyUsersMenuAsAdmin()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);


            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser(UserAdmin, PasswordAdmin);

            //Act
            homePage.GoToMenu("Administrare");
            homePage.GoToMenu("Utilizatori");

            //Assert



        }

        [Test]
        //i.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori, alegeti un utilizator si editati.
        public void EditUserAsAdmin()
        {


            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            UserPage userPage = new UserPage(Driver);
            SignUpPage signUpPage = new SignUpPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser(UserAdmin, PasswordAdmin);
            homePage.GoToMenu("Administrare");
            homePage.GoToMenu("Utilizatori");

            //Act
            userPage.EditUser();
            signUpPage.FillEmailField("gabytest@test.com");
            loginPage.AuthenticateUser(UserGaby, PasswordGaby);
            userPage.UpdateUser();
            //Assert
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "Details updated");

            userPage.UpdateUser();
        }
    }
}