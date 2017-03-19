using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;
using CompareTheMarketProject.Data;

namespace AutomatedAcceptanceTest
{
    [TestClass]
    public class FeatureFile 
    {
        private StepDefinition stepDefinition = new StepDefinition();

        [TestInitialize]
        public void Initialise()
        {
            stepDefinition.Init();
        }


        [TestMethod]
        public void CompareGasAndElectricityUsingSameProvider()
        {
            stepDefinition.OpenWebPage();
            this.Given(x => this.stepDefinition.Given_The_Customer_Postcode_Is_Set(TestData.postcode))
                .And(x => this.stepDefinition.Given_The_Customer_Has_A_Bill())
                .And(x => this.stepDefinition.Given_I_Compare_Gas_And_Electricity_Using_Same_Provider(TestData.Provider.BritishGas))
                .And(x => this.stepDefinition.When_I_Navigate_To_Electricity_Details_Page())
                .And(x => this.stepDefinition.When_I_Select_The_Tariff(TestData.Utility.Electricity,TestData.Tariff.Standard))
                .And(x => this.stepDefinition.When_I_Select_The_Electricity_Meter_Type())
                .And(x => this.stepDefinition.When_I_Select_The_Payment_Type(TestData.Utility.Electricity,TestData.PaymentType.MonthlyDirectDebit))
                .And(x => this.stepDefinition.When_I_Select_The_Electricity_As_Main_Source_Of_Heating())
                .And(x => this.stepDefinition.When_I_Select_The_Electricity_Usage_Select_Pound())
                .And(x => this.stepDefinition.When_I_Select_The_Electricity_Usage_Send_Value_Pound(TestData.poundElectricityElement,TestData.amount))
                .And(x => this.stepDefinition.When_I_Select_The_Bill_Date(TestData.Utility.Electricity,TestData.date))
                .And(x => this.stepDefinition.When_I_Navigate_To_Gas_Details_Page())
                .And(x => this.stepDefinition.When_I_Select_The_Tariff(TestData.Utility.Gas,TestData.Tariff.Standard))
                .And(x => this.stepDefinition.When_I_Select_The_Gas_Meter_Type())
                .And(x => this.stepDefinition.When_I_Select_The_Payment_Type(TestData.Utility.Gas,TestData.PaymentType.MonthlyDirectDebit))
                .And(x => this.stepDefinition.When_I_Select_The_Gas_As_Main_Source_Of_Heating())
                .And(x => this.stepDefinition.When_I_Select_The_Gas_Usage_Select_Pound())
                .And(x => this.stepDefinition.When_I_Select_The_Gas_Usage_Send_Value_Pound(TestData.poundGasElement,TestData.amount))
                .And(x => this.stepDefinition.When_I_Select_The_Bill_Date(TestData.Utility.Gas,TestData.date))
                .And(x => this.stepDefinition.When_I_Navigate_To_Preference_Page())
                .And(x => this.stepDefinition.When_I_Select_The_Fixed_rate_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Payment_Type_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Email_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Marketing_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Terms_Preference())
                 .And(x => this.stepDefinition.When_I_Submit_All_Details())
                .Then(x => this.stepDefinition.Then_The_Result_Is_Provided(TestData.Provider.BritishGas,TestData.Provider.BritishGas,TestData.PaymentType.MonthlyDirectDebit,TestData.Tariff.Standard))
                .BDDfy();

        }


        [TestMethod]
        public void CompareGasAndElectricityUsingDifferentProvider()
        {
            stepDefinition.OpenWebPage();
            this.Given(x => this.stepDefinition.Given_The_Customer_Postcode_Is_Set(TestData.postcode))
                .And(x => this.stepDefinition.Given_The_Customer_Has_No_Bill())
                .And(x => this.stepDefinition.Given_I_Compare_Gas_And_Electricity_Using_Different_Provider(TestData.Provider.BritishGas,TestData.Provider.EDFEnergy))
                .And(x => this.stepDefinition.When_I_Navigate_To_Electricity_Details_Page())
                .And(x => this.stepDefinition.When_I_Select_No_Pre_Payment_Meter())
                .And(x => this.stepDefinition.When_I_Select_The_Electricity_Meter_Type())
                .And(x => this.stepDefinition.When_I_Select_The_Electricity_Usage_Send_Value_Pound(TestData.poundElectricityCurrentElement,TestData.amount))
                .And(x => this.stepDefinition.When_I_Select_The_Gas_Usage_Send_Value_Pound(TestData.poundGasCurrentElement,TestData.amount))
                .And(x => this.stepDefinition.When_I_Navigate_To_Preference_Page())
                .And(x => this.stepDefinition.When_I_Select_The_Fixed_rate_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Payment_Type_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Email_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Marketing_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Terms_Preference())
                .And(x => this.stepDefinition.When_I_Submit_All_Details())
                .Then(x => this.stepDefinition.Then_The_Result_Is_Provided(TestData.Provider.BritishGas,TestData.Provider.EDFEnergy,TestData.PaymentType.MonthlyDirectDebit,TestData.Tariff.None))
                .BDDfy();

        }

        [TestMethod]
        public void CompareElectricityOnlyUsingProvider()
        {
            stepDefinition.OpenWebPage();
            this.Given(x => this.stepDefinition.Given_The_Customer_Postcode_Is_Set(TestData.postcode))
                .And(x => this.stepDefinition.Given_The_Customer_Has_No_Bill())
                .And(x => this.stepDefinition.Given_I_Compare_Electricity_Only_Using_Provider(TestData.Provider.BritishGas))
                .And(x => this.stepDefinition.When_I_Navigate_To_Electricity_Details_Page())
                .And(x => this.stepDefinition.When_I_Select_No_Pre_Payment_Meter())
                .And(x => this.stepDefinition.When_I_Select_The_Electricity_Meter_Type())
                .And(x => this.stepDefinition.When_I_Select_The_Electricity_Usage_Send_Value_Pound(TestData.poundElectricityCurrentElement,TestData.amount))
                .And(x => this.stepDefinition.When_I_Navigate_To_Preference_Page())
                .And(x => this.stepDefinition.When_I_Select_The_Fixed_rate_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Payment_Type_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Email_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Marketing_Preference())
                .And(x => this.stepDefinition.When_I_Select_The_Terms_Preference())
                .And(x => this.stepDefinition.When_I_Submit_All_Details())
                .Then(x => this.stepDefinition.Then_The_Result_Is_Provided(TestData.Provider.BritishGas,TestData.Provider.None,TestData.PaymentType.None,TestData.Tariff.None))
                .BDDfy();

        }

        [TestCleanup]
        public void TestCleanUp()
        {
            stepDefinition.Dispose();
        }
    }
}
