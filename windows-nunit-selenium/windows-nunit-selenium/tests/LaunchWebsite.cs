using NUnit.Framework;
using System.Linq;
using windows_nunit_selenium.framework;
using windows_nunit_selenium.page_objects;

namespace windows_nunit_selenium
{
    public class LaunchWebsite : BaseTest
    {     

        [Test]
        public void SearchDrillingMachine()
        {
            var searchTerm = "drilling";
            var homePage = new HomePage(driver);
            homePage.SetSearchTerm(searchTerm);
            var searchPage = homePage.ClickSearchButton();
            StringAssert.IsMatch($@"([1-9]*) results for {searchTerm}", searchPage.GetHeaderText());
            Assert.IsTrue(searchPage.AreProductsDisplayed());
           
        }

        [Test]
        public void ShowRecentSearches()
        {
            var searchTerm = "drilling";
            var homePage = new HomePage(driver);
            homePage.SetSearchTerm(searchTerm);
            var searchPage = homePage.ClickSearchButton();
            StringAssert.IsMatch($@"([1-9]*) results for {searchTerm}", searchPage.GetHeaderText());
            searchPage.ClickSearchBox();
            Assert.IsTrue(searchPage.GetSearchHistoryLinks().Any(searchTerm.Contains));
        }


        [Test]
        public void SearchInvalidTerm()
        {
            var searchTerm = "yerongpan";
            var homePage = new HomePage(driver);
            homePage.SetSearchTerm(searchTerm);
            var searchPage = homePage.ClickSearchButton();
            StringAssert.IsMatch($@"0 results for {searchTerm}", searchPage.GetHeaderText());
        }
    }
}