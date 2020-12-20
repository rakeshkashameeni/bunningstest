using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace windows_nunit_selenium.page_objects
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { 
         
        }


        public SearchResultsPage ClickSearchButton()
        {
            searchButton.Click();
            return new SearchResultsPage(driver);

        }
    }
}
