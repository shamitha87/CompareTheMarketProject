namespace CompareTheMarketProject.Data
{
    public class TestData
    {
        public static string baseURL = "https://energy.comparethemarket.com/energy/v2/?AFFCLIE=TSTT";
        public static string postcode = "PE2 6YS";
        public static string header = "main-heading";
        public static string compareBoth = "compare-what-both";
        public static string sameSupplier = "same-supplier-yes";
        public static string differentSupplier = "same-supplier-no";
        public static string poundElectricityElement = "electricity-spend";
        public static string poundGasElement = "gas-spend";
        public static string poundElectricityCurrentElement = "electricity-current-spend";
        public static string poundGasCurrentElement = "gas-current-spend";
        public static string compareElectricity = "compare-what-electricity";
        public static string compareGas= "compare-what-gas";
        public static string email = "abc@abc.com";
        public static string amount = "50";
        public static string date = "15";


        public enum Utility
        {
            Gas,
            Electricity
        };
       

        public enum Provider
        {
            BritishGas,
            EDFEnergy,
            Eon,
            Npower,
            ScottishPower,
            SSE,
            None
        }
       public enum PaymentType
        {
           
            MonthlyDirectDebit,
            None
            //todo
        };

        public enum Tariff
        {
            Standard,
            None
            //todo
        };

    }
}
