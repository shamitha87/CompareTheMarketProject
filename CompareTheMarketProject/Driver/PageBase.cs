using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace CompareTheMarketProject.Driver
{
    public class PageBase
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        public void Init()
        {
            driver = new FirefoxDriver();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
        }
        public void NavigateToURL(string url)
        {
              driver.Navigate().GoToUrl(url);
        }
        public void Dispose()

        {
            driver.Dispose();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
