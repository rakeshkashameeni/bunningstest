using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace windows_nunit_selenium.framework
{
    public class BaseTest
    {
        public IWebDriver driver = null;
        private string url = "https://www.bunnings.com.au/";

        [SetUp]
        public void Setup()
        {
            try
            {
                driver = new ChromeDriver();
                driver.Url = url;
                driver.Manage().Window.Maximize();
                driver.Navigate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TearDown]
        public void TearDown()
        {         
                driver.Close();
                driver.Quit();           
        }
    }
}
