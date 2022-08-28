using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace selenium
{
    class program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }
        [SetUp]        
        
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        [Test]
        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("executeautomation");

        }
        [TearDown]
        public void cleanup()
        {
            driver.Close();
        }
    }
}

