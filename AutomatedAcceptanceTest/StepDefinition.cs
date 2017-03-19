using CompareTheMarketProject.Data;
using CompareTheMarketProject.Pages;
using OpenQA.Selenium;
using CompareTheMarketProject.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace AutomatedAcceptanceTest
{
    public class StepDefinition : CompareMarketBasePage
    {


        public void OpenWebPage()
        {
            NavigateToURL(TestData.baseURL);

        }


        public void Given_The_Customer_Postcode_Is_Set(string postcode)
        {
            Assert.IsTrue(SupplierPage.IsPageDisplayed());
            SupplierPage.EnterPostcode();

        }

        public void Given_The_Customer_Has_A_Bill()
        {
            SupplierPage.HaveBill();


        }

        public void Given_The_Customer_Has_No_Bill()
        {
            SupplierPage.DoNotHaveBill();
        }

        public void Given_I_Compare_Gas_And_Electricity_Using_Same_Provider(TestData.Provider provider)
        {
            SupplierPage.SelectProvider(provider);



        }

        public void Given_I_Compare_Gas_And_Electricity_Using_Different_Provider(TestData.Provider electProvider, TestData.Provider gasProvider)
        {
            SupplierPage.SelectProvider(electProvider, gasProvider);
        }

        public void Given_I_Compare_Electricity_Only_Using_Provider(TestData.Provider provider)
        {
            SupplierPage.SelectElectricityProvider(provider);
        }

        public void When_I_Navigate_To_Electricity_Details_Page()
        {

            ClickById("goto-your-supplier-details");
        }


        public void When_I_Navigate_To_Preference_Page()
        {

            ClickById("goto-your-energy");
        }

        public void When_I_Submit_All_Details()
        {
            ClickById("email-submit");
        }

        public void When_I_Select_The_Marketing_Preference()
        {
            ClickByLabel("marketingPreference");


        }

        public void When_I_Select_The_Terms_Preference()
        {
            ClickByLabel("terms");
        }

        public void When_I_Select_The_Email_Preference()
        {
            ClickById("Email").SendKeys(TestData.email);
        }

        public void When_I_Select_The_Payment_Type_Preference()
        {

            ClickByLabel("pre-select-payment-monthly");
        }

        public void When_I_Select_The_Fixed_rate_Preference()
        {
            WaitAndClickElementByLabel("pre-select-fixed");
        }



        public void When_I_Select_The_Gas_Usage_Select_Pound()
        {
            ClickByLabel("poundSpendG");

        }

        public void When_I_Select_The_Gas_Usage_Send_Value_Pound(string element, string amount)
        {
            ClickByIdAndSend(element, amount);
        }

        public void When_I_Select_The_Gas_As_Main_Source_Of_Heating()
        {
            ClickByLabel("gas-main-heating-yes");
        }


        public void When_I_Select_The_Payment_Type(TestData.Utility utility, TestData.PaymentType type)
        {
            WaitAndClickElementId(SupplierPageUtility.GetPaymentMethodElement(utility));
            IWebElement payType = driver.FindElement(By.Id(SupplierPageUtility.GetPaymentMethodElement(utility)));
            var selectPayment = new SelectElement(payType);
            selectPayment.SelectByText(SupplierPageUtility.GetPaymentType(type));
        }

       
        public void When_I_Select_The_Gas_Meter_Type()
        {

        }

        public void When_I_Select_No_Pre_Payment_Meter()
        {
            WaitAndClickElementByLabel("economy-7-no");
        }

        public void When_I_Select_The_Tariff(TestData.Utility utility,TestData.Tariff tariff)
        {
            Assert.IsTrue(SupplierPage.IsPageDisplayed(), "Page not displayed");
            WaitAndClickElementId(SupplierPageUtility.GetTariffElement(utility));
            IWebElement electricityTariff = driver.FindElement(By.Id(SupplierPageUtility.GetTariffElement(utility)));
            var selectTariff = new SelectElement(electricityTariff);
            selectTariff.SelectByText(tariff.ToString());
        }


        public void When_I_Navigate_To_Gas_Details_Page()
        {
            ClickById("goto-your-energy");
        }

        public void When_I_Select_The_Bill_Date(TestData.Utility utility, string date)
        {

            ClickBySpan(SupplierPageUtility.GetDatePickerClass(utility));
            WaitAndClickElementId(SupplierPageUtility.GetDatePickerTable(utility));
            GetSelectedDate(driver.FindElement(By.Id(SupplierPageUtility.GetDatePickerTable(utility))), date).Click();

        }




        public void When_I_Select_The_Electricity_Usage_Select_Pound()
        {
            ClickByLabel("poundSpend");


        }

        public void When_I_Select_The_Electricity_Usage_Send_Value_Pound(string element, string amount)
        {
            ClickByIdAndSend(element, amount);

        }

        public void When_I_Select_The_Electricity_As_Main_Source_Of_Heating()
        {
            ClickByLabel("electricity-main-heating-no");
        }



        public void When_I_Select_The_Electricity_Meter_Type()
        {
            ClickByLabel("economy-7-no");


        }



        public void Then_The_Result_Is_Provided(TestData.Provider elecProvider, TestData.Provider gasProvider, TestData.PaymentType type, TestData.Tariff tariff)
        {

            AssertOnHeader();
            AssertOnProvider(elecProvider,gasProvider);
            AssertOnPaymentTypeAndTariff(type, tariff);
            
           //todo more asserts on result table
        }

        private static void AssertOnHeader()
        {

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div//h2[text()='Current tariff and usage']")));
            Assert.IsTrue(ResultsPage.IsPageDisplayed(), "Page not displayed");
            Assert.IsNotNull(driver.FindElement(By.XPath("//section/h2[text()='Your Results']")));
        }

        private static void AssertOnProvider(TestData.Provider elecProvider, TestData.Provider gasProvider)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[@class='personal-projection-inner ng-scope']"));
            System.Threading.Thread.Sleep(7000);
            Assert.IsTrue(element.Text.Contains(SupplierPageUtility.GetProviderName(elecProvider)));
            Assert.IsTrue(element.Text.Contains(SupplierPageUtility.GetProviderName(gasProvider)));
        }

        private static void AssertOnPaymentTypeAndTariff(TestData.PaymentType type, TestData.Tariff tariff)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[@class='personal-projection-inner ng-scope']"));
            if (!tariff.Equals(TestData.Tariff.None))
            {
                Assert.IsTrue(element.Text.Contains(tariff.ToString()));
            }
            if (!type.Equals(TestData.PaymentType.None))
            {
                Assert.IsTrue(element.Text.ToUpper().Contains(SupplierPageUtility.GetPaymentType(type).ToUpper()));
            }
        }
    }
}
