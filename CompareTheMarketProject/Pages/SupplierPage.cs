using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompareTheMarketProject.Driver;
using CompareTheMarketProject.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using CompareTheMarketProject.Utility;

namespace CompareTheMarketProject.Pages
{
    public class SupplierPage : CompareMarketBasePage
    {
        public static bool IsPageDisplayed()
        {
            return CompareMarketBasePage.IsPageDisplayed(TestData.header);
        }
        

        public static void EnterPostcode()
        {
            ClickById("your-postcode").SendKeys(TestData.postcode);
            ClickById("find-postcode");
        }

        public static void HaveBill()
        {
            
            ClickBySpan("icon have-bill-yes");
        }

        public static void DoNotHaveBill()
        {
            ClickBySpan("icon have-bill-no");

        }

      
        //private static void WaitAndClickProvider(string providerElement)
        //{
        //    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[@for=" + providerElement + "]"))).Click();

        //}
        public static void SelectProvider(TestData.Provider provider)
        {
            WaitAndClickElementByLabel(TestData.sameSupplier);
            WaitAndClickElementByLabel(TestData.compareBoth);
            WaitAndClickElementByLabel(SupplierPageUtility.GetDualProviderDetails(provider));
        }

        public static void SelectProvider(TestData.Provider elecProvider, TestData.Provider gasProvider)
        {
            WaitAndClickElementByLabel(TestData.compareBoth);

            WaitAndClickElementByLabel(SupplierPageUtility.GetGasProviderDetails(gasProvider));
            WaitAndClickElementByLabel(SupplierPageUtility.GetElectricityProviderDetails(elecProvider));
        }

       
        public static void SelectElectricityProvider(TestData.Provider elecProvider)
        {

            WaitAndClickElementByLabel(TestData.compareElectricity);
            WaitAndClickElementByLabel(SupplierPageUtility.GetElectricityProviderDetails(elecProvider));
           

        }

   
        

        public static void SelectGasProvider( TestData.Provider gasProvider)
        {
            WaitAndClickElementByLabel(TestData.compareGas);
            WaitAndClickElementByLabel(SupplierPageUtility.GetGasProviderDetails(gasProvider));
        }
    }
}
