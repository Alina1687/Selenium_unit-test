using OpenQA.Selenium;


namespace Selenium_unit_test.PageObjects
{
   partial class HomePage
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement AutentificareButton => driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement InscriereButton => driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        public IWebElement DeconectareButton => driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement VeziDetaliiButton => driver.FindElement(By.CssSelector(".btn-primary"));
       
        public IWebElement Category => driver.FindElement(By.CssSelector(".list-group-item.disabled"));
       private IWebElement NavBar => driver.FindElement(By.Id("collapsibleNavbar"));

    }
}