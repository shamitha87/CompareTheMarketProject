using CompareTheMarketProject.Data;



namespace CompareTheMarketProject.Utility
{
    public class SupplierPageUtility 

    { 
        public static string GetProviderName(TestData.Provider provider)
        {
            string output = null;
            switch(provider)
            {
                case TestData.Provider.BritishGas:
                   output = "British Gas";
                   break;
                case TestData.Provider.EDFEnergy:
                    output = "EDF Energy";
                    break;
                case TestData.Provider.None:
                    output = "";
                    break;
                //todo
            }
            return output;
        }

        public static string GetPaymentType(TestData.PaymentType type)
        {
            string output = "null";
            switch(type)
            {
                case TestData.PaymentType.MonthlyDirectDebit:
                    output = "Monthly Direct Debit";
                    break;
            }
            return output;
        }

        public static string GetDualProviderDetails(TestData.Provider provider)
        {
            string output;
            switch(provider)
            {
                case TestData.Provider.BritishGas:
                    output = "dual-top-six-british-gas";
                    break;
                case TestData.Provider.EDFEnergy:
                    output = "dual-top-six-edf";
                    break;
                case TestData.Provider.Eon:
                    output = "dual-top-six-eon";
                    break;
                case TestData.Provider.Npower:
                    output="dual-top-six-npower";
                    break;
                case TestData.Provider.ScottishPower:
                    output="dual-top-six-scottish-power";
                    break;
                case TestData.Provider.SSE:
                    output="dual-top-six-sse";
                    break;
                default:
                    output = "Null";
                    break;
            }
            return output;
        }
        public static string GetElectricityProviderDetails(TestData.Provider provider)
        {
            string output;
            switch (provider)
            {
                case TestData.Provider.BritishGas:
                    output = "electricity-top-six-british-gas";
                    break;
                case TestData.Provider.EDFEnergy:
                    output = "electricity-top-six-edf";
                    break;
                case TestData.Provider.Eon:
                    output = "";//todo
                    break;
                case TestData.Provider.Npower:
                    output = "";//todo
                    break;
                case TestData.Provider.ScottishPower:
                    output = "";//todo
                    break;
                case TestData.Provider.SSE:
                    output = "";//todo
                    break;
                default:
                    output = "Null";
                    break;
            }
            return output;
        }

        public static string GetDatePickerClass(TestData.Utility utility)
        {
            string output = null;
            switch (utility)
            {
                case TestData.Utility.Electricity:
                    output = "date-picker-icon datepicker-elec-icon";
                    break;
                case TestData.Utility.Gas:
                    output = "date-picker-icon datepicker-gas-icon";
                    break;
            }
            return output;
         }

        public static string GetPaymentMethodElement(TestData.Utility utility)
        {
            string output = null;
            switch (utility)
            {
                case TestData.Utility.Electricity:
                    output = "electricity-payment-method-dropdown-link";
                    break;
                case TestData.Utility.Gas:
                    output = "gas-payment-method-dropdown-link";
                    break;
            }
            return output;
        }

        public static string GetTariffElement(TestData.Utility utility)
        {
            string output = null;
            switch (utility)
            {
                case TestData.Utility.Electricity:
                    output = "electricity-tariff-additional-info";
                    break;
                case TestData.Utility.Gas:
                    output = "gas-tariff-additional-info";
                    break;
            }
            return output;
        }


        public static string GetDatePickerTable(TestData.Utility utility)
        {
            string output = null;
            switch (utility)
            {
                case TestData.Utility.Electricity:
                    output = "electricity-bill-day_table";
                    break;
                case TestData.Utility.Gas:
                    output = "gas-bill-day_table";
                    break;
            }
            return output;
        }

        public static string GetGasProviderDetails(TestData.Provider provider)
        {
            string output;
            switch (provider)
            {
                case TestData.Provider.BritishGas:
                    output = "gas-top-six-british-gas";
                    break;
                case TestData.Provider.EDFEnergy:
                    output = "gas-top-six-edf";
                    break;
                case TestData.Provider.Eon:
                    output = "";//todo
                    break;
                case TestData.Provider.Npower:
                    output = "";//todo
                    break;
                case TestData.Provider.ScottishPower:
                    output = "";//todo
                    break;
                case TestData.Provider.SSE:
                    output = "";//todo
                    break;
                default:
                    output = "Null";
                    break;
            }
            return output;
        }


    }
}
