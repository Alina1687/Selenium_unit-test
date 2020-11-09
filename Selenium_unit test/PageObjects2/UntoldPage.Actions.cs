using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_unit_test.PageObjects2
{
    partial class UntoldPage
    {

        public void AcceptTerms()
        {
            driver.SwitchTo().Frame(Frame); ;
            AgreeButton.Click();
            driver.SwitchTo().DefaultContent();
        }

    }
}
