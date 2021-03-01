using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class FinancialData
    {
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
        public double Spread { get; set; }
        public double OpenPrice { get; set; }
        public double Price { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        public double Change { get; set; }
        public double ChangeInPercent { get; set; }
        public double Volume { get; set; }
        public double HighD { get; set; }
        public double LowD { get; set; }
        public double HighY { get; set; }
        public double LowY { get; set; }
        public double StartY { get; set; }
        public double ChangeOn { get; set; }
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
        public double Cpn { get; set; }
        public DateTime Maturity { get; set; }
        public double KRD_3YR { get; set; }
        public string RISK_COUNTRY { get; set; }
        public string MUNI_SECTOR { get; set; }
        public double ZV_SPREAD { get; set; }
        public double KRD_5YR { get; set; }
        public double KRD_1YR { get; set; }
        public double? PD_WALA { get; set; }
        public string Settlement { get; set; } = "Cash";
        public string Contract { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double ChangeP { get; set; }
        public double OpenPriceDiff { get; set; }
        public double BuyDiff { get; set; }
        public double SellDiff { get; set; }
        public double StartYDiff { get; set; }
        public double HighYDiff { get; set; }
        public double LowYDiff { get; set; }
        public double HighDDiff { get; set; }
        public double LowDDiff { get; set; } 
        public int ID { get; set; }
    }

    public class Region
    {
        public Region(string region, string[] countries)
        {
            RegionName = region;
            Countries = countries;
        }
        public string RegionName { get; set; }
        public string[] Countries { get; set; }
    }

    public class PercentChange
    {
        public double Price { get; set; } = 0;
        public double ChangePercent { get; set; } = 0;
    }
}
