using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheMarketProject.Data
{
    public class SupplierPageData
    {
        public static string baseURL = "https://energy.comparethemarket.com/energy/v2/?AFFCLIE=TSTT";
        public static string postcode = "W9 2DG";
        public static string header = "main-heading";
        public static string compareBoth = "'compare-what-both'";
        public static string sameSupplier = "'same-supplier-yes'";
        public static string differentSupplier = "'same-supplier-no'";
        public static string poundElectricityElement = "electricity-spend";
        public static string poundGasElement = "gas-spend";
        public static string poundElectricityCurrentElement = "electricity-current-spend";
        public static string poundGasCurrentElement = "gas-current-spend";
        public static string compareElectricity = "'compare-what-electricity'";
        public static string compareGas= "'compare-what-gas'";

        // public static string CompareBoth { get => compareBoth; }

        public enum Provider
        {
            BritishGas,
            EDFEnergy,
            Eon,
            Npower,
            ScottishPower,
            SSE
        }
       
    }
}
