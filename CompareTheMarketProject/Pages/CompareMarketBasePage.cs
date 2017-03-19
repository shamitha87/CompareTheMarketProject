using System.Collections.Generic;
using CompareTheMarketProject.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CompareTheMarketProject.Pages
{
    public class CompareMarketBasePage : PageBase
    {

        public static bool IsPageDisplayed(string header)
        {
            var element = driver.FindElement(By.ClassName(header));
            return element.Displayed;
        }

        public static IWebElement ClickById(string id)
        {
            IWebElement element = driver.FindElement(By.Id(id));
            element.Click();
            return element;
        }

        public static IWebElement ClickByLabel(string label)
        {
            IWebElement element = driver.FindElement(By.XPath("//label[@for='" + label + "']"));
            element.Click();
            return element;
        }

        public static void ClickByIdAndSend(string id, string key)
        {
            ClickById(id).SendKeys(key);
        }
        protected static void ClickBySpan(string span)
        {
            var element = driver.FindElement(By.CssSelector("span[class='" + span + "']"));
            element.Click();
        }

        protected static void WaitAndClickElementByLabel(string element)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[@for='"+element+"']"))).Click();
        }

        protected static void WaitAndClickElementId(string element)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)));
        }

        protected static IWebElement GetSelectedDate(IWebElement element, string date)
        {
            IList<IWebElement> elements = element.FindElements(By.XPath("//tr//td//div[text()='" + date + "']"));
            foreach(IWebElement ele in elements)
            {
                if (ele.Text.Contains(date))
                {
                    return ele;
                }
            }
            return null;
            
        }
    }
}
