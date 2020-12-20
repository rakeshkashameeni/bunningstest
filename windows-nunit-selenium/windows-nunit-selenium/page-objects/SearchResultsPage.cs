using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace windows_nunit_selenium.page_objects
{
    public class SearchResultsPage : BasePage
    {
        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }
        protected IWebElement header => driver.FindElement(By.CssSelector(".responsive-search-title"));
        protected IWebElement noResultsText => driver.FindElement(By.CssSelector(".responsive-search-suggestions-banner__content"));
        protected IList<IWebElement> products => driver.FindElements(By.XPath("//article//a"));

        public string GetHeaderText()
        {
            return header.Text;
        }

        public bool AreProductsDisplayed()
        {
            return products.Count > 0;
        }

        public string GetNoResultsText()
        {
            return noResultsText.Text;
        }

      
    }
}
