using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTest
{
    [TestClass]
    public class SeleniumTest
    {
        private readonly string appURI = "https://localhost:7198/";

        [TestMethod]
        public void Test1()
        {
            var opt = new ChromeOptions();
            opt.AddArgument("--headless");
            using IWebDriver driver = new ChromeDriver(opt);


            driver.Navigate().GoToUrl(appURI);
            driver.FindElement(By.Name("button")).Click();
        }
    }
}