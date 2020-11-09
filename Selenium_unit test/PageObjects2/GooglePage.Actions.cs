using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTest.PageObjects_2
{
    partial class GooglePage
    {
        public void AcceptTerms()
        {
            driver.SwitchTo().Frame(Frame); ;
            AgreeButton.Click();
            driver.SwitchTo().DefaultContent();
        }

        public void GoogleSearch(string searchText)
        {
            SearchTextBox.SendKeys(searchText);
            Thread.Sleep(1000);
            GoogleSearchButton.Click();
        }

        public void ClickResultFromImages()
        {
            ImagesLink.Click();
            Image1.Click();
        }

        public void BackToImages()
        {
            BackToIcon.Click();
        }

        public bool PanelDisplayed()
        {
            return Panel.Displayed;
        }

    }
}