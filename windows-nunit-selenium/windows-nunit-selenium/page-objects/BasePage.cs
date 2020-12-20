using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace windows_nunit_selenium.page_objects
{
    public class BasePage
    {
        public BasePage(IWebDriver driver) {
            this.driver = driver;
        }

        protected IWebDriver driver;
        protected IWebElement searchBox => driver.FindElement(By.XPath("//input[@data-page='/search']"));
        protected IWebElement searchButton => driver.FindElement(By.CssSelector(".search-container_icon-search"));
        protected IList<IWebElement> suggetedProducts => driver.FindElements(By.CssSelector(".ui-menu-item"));

        protected IList<IWebElement> searchHistoryLinks => driver.FindElements(By.CssSelector(".search-container_history_link"));

        

        public void SetSearchTerm(string term)
        {
            searchBox.SendKeys(term);
        }

        public void ClickSearchBox()
        {
            searchBox.Click();
        }

        public string[] GetSearchHistoryLinks()
        {
            return searchHistoryLinks.Select(e => e.Text).ToArray();
        }
    }
}
