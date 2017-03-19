using OpenQA.Selenium;

namespace CompareTheMarketProject.Pages
{
    public class ResultsPage : CompareMarketBasePage
    {
        public static bool IsPageDisplayed()
        {
            var element = driver.FindElement(By.XPath("//div//h2[text()='Current tariff and usage']"));
            return element.Displayed;
        }

       

      
    }
}
