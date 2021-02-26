using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class FinancialData
    {
        private static readonly string[] Categories = new[]
        {
            "Metal", "Oil", "Livestock", "Interest Rate", "Index", "Currencies", "Agriculture"
        };

        private static readonly string[] Metals = new[]
        {
            "Gold", "Silver", "Copper", "Platinum", "Palladium"
        };

        private static readonly string[] Oils = new[]
        {
            "Oil", "Brent", "Natural Gas", "RBOB Gas", "Diesel", "Ethanol", "Uranium", "Coal"
        };

        private static readonly string[] Agricultures = new[]
        {
            "Wheat", "Corn", "Sugar", "Soybean", "Soy oil", "Soy Meat", "OJ Future", "Coffee", "Cocoa", "Rice", "Oats", "Milk", "Cotton", "Lumber"
        };

        private static readonly string[] Livestocks = new[]
        {
            "LV Cattle", "FD Cattle", "Lean Hogs"
        };

        private static readonly string[] Currencies = new[]
        {
            "USD IDX Future", "USD/JPY Future", "GBP/USD Future", "AUD/USD Future", "DOW Future", "S&P Future", "NAS Future", "S&P MID MINI"
        };

        private static readonly string[] InterestRates = new[]
        {
            "US 30YR Future", "US 2Y Future", "US 10YR Future", "Euro$ 3M"
        };

        private string _type;

        public string Category { get; set; }
        //public string Category => Categories[new Random().Next(Categories.Length)];
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }

            //set
            //{
            //    string type = "";
            //    var rnd = new Random();

            //    switch (Category)
            //    {
            //        case "Metal":
            //            type = Metals[rnd.Next(Metals.Length)];
            //            break;
            //        case "Oil":
            //            type = Oils[rnd.Next(Oils.Length)];
            //            break;
            //        default:
            //            break;
            //    }

            //    _type = type;
            //}
        }
        public float Spread { get; set; }
        public float OpenPrice { get; set; }
        public float Price { get; set; }
        public float Buy { get; set; }
        public float Sell { get; set; }
        public float Change { get; set; }
        public float ChangeInPercent { get; set; }
        public float Volume { get; set; }
        public float High { get; set; }
        public float Low { get; set; }
        public float HighY { get; set; }
        public float LowY { get; set; }
        public float StartY { get; set; }
        public float ChangeOn { get; set; }
        public string IndGrou { get; set; }
        public string IndSect { get; set; }
        public string IndSubg { get; set; }
        public string SecType { get; set; }
        public string CpnTyp { get; set; }
        public string IssuerN { get; set; }
        public string Moodys { get; set; }
        public string Fitch { get; set; }
        public string DBRS { get; set; }
        public string CollatT { get; set; }
        public string Curncy { get; set; }
        public string Security { get; set; }
        public string Sector { get; set; }
        public int CUSIP { get; set; }
        public string Ticker { get; set; }
        public float Cpn { get; set; }
        public DateTime Maturity { get; set; }
        public float KRD_3YR { get; set; }
        public string RISK_COUNTRY { get; set; }
        public string MUNI_SECTOR { get; set; }
        public float ZV_SPREAD { get; set; }
        public float KRD_5YR { get; set; }
        public float KRD_1YR { get; set; }
        public float? PD_WALA { get; set; }
    }
}
