using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UiTests
{
    public class SeleniumShould
    {
        [Fact]
        [Trait ("Category","Smoke")]
        public void LoadPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.google.com/");
            }

        }
    }
}
