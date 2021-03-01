using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Helper
    {
        public readonly Region[] Regions = new[]
        {
            new Region("North America", new string[] { "Canada", "United States", "Mexico" }),
            new Region("Middle East", new string[] { "Turkey", "Iraq", "Saudi Arabia", "Syria", "UAE", "Israel", "Jordan", "Lebanon", "Oman", "Kuwait", "Qatar", "Bahrain", "Iran" }),
            new Region("Europe", new string[] { "Russia", "Germany", "France", "United Kingdom", "Italy", "Spain", "Poland", "Romania", "Netherlands", "Belgium", "Greece", "Portugal", "Czech Republic", "Hungary", "Sweden", "Austria", "Switzerland", "Bulgaria", "Denmark", "Finland", "Slovakia", "Norway", "Ireland", "Croatia", "Slovenia", "Estonia", "Iceland" }),
            new Region("Africa", new string[] { "Nigeria", "Ethiopia", "Egypt", "South Africa", "Algeria", "Morocco", "Cameroon", "Niger", "Senegal", "Tunisia", "Libya" }),
            new Region("Asia Pacific", new string[] { "Afghanistan", "Australia", "Azerbaijan", "China", "Hong Kong", "India", "Indonesia", "Japan", "Malaysia", "New Zealand", "Pakistan", "Philippines", "Korea", "Singapore", "Taiwan", "Thailand" }),
            new Region("South America", new string[] { "Argentina", "Bolivia", "Brazil", "Chile", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" })
        };

        public static readonly string[] Categories = new[]
        {
            "Metal", "Oil", "Livestock", "Interest Rate", "Index", "Currencies", "Agriculture"
        };

        public static readonly string[] Metals = new[]
        {
            "Gold", "Silver", "Copper", "Platinum", "Palladium"
        };

        public static readonly string[] Oils = new[]
        {
            "Oil", "Brent", "Natural Gas", "RBOB Gas", "Diesel", "Ethanol", "Uranium", "Coal"
        };

        public static readonly string[] Agricultures = new[]
        {
            "Wheat", "Corn", "Sugar", "Soybean", "Soy oil", "Soy Meat", "OJ Future", "Coffee", "Cocoa", "Rice", "Oats", "Milk", "Cotton", "Lumber"
        };

        public static readonly string[] Livestocks = new[]
        {
            "LV Cattle", "FD Cattle", "Lean Hogs"
        };

        public static readonly string[] Currencies = new[]
        {
            "USD IDX Future", "USD/JPY Future", "GBP/USD Future", "AUD/USD Future", "DOW Future", "S&P Future", "NAS Future", "S&P MID MINI"
        };

        public static readonly string[] InterestRates = new[]
        {
            "US 30YR Future", "US 2Y Future", "US 10YR Future", "Euro$ 3M"
        };

        public static readonly string[] Settlements = new[]
        {
            "Deliverable", "Cash"
        };

        public static readonly string[] Contracts = new[]
        {
            "Forwards", "Futures", "Options", "Swap", "CFD"
        };
        /// <summary>
        /// Generates new data based on passed length
        /// </summary>
        /// <param name="data"></param>
        /// <param name="newCount"></param>
        /// <returns></returns>
        public FinancialData[] generatedata(FinancialData[] data, int newCount)
        {

            FinancialData[] newData = new FinancialData[newCount];
            var rng = new Random();
            var getRandomDate = RandomDayFunc();
            FinancialData finDataEntity;

            for (int i = 0; i < newCount; i++)
            {
                var randomIndex = rng.Next(data.Length);
                finDataEntity = data[randomIndex];
                // creates a number between 0 and 1
                finDataEntity.Settlement = Settlements[rng.Next(2)];
                finDataEntity.Contract = Contracts[rng.Next(5)];
                finDataEntity.LastUpdated = getRandomDate();
                finDataEntity.OpenPriceDiff = Math.Round((((finDataEntity.OpenPrice - finDataEntity.Price) / finDataEntity.Price) * 100) * 15, 4);
                finDataEntity.BuyDiff = Math.Round((((finDataEntity.Buy - finDataEntity.Price) / finDataEntity.Price) * 100) * 15, 4);
                finDataEntity.SellDiff = Math.Round((((finDataEntity.Sell - finDataEntity.Price) / finDataEntity.Price) * 100) * 15, 4);
                finDataEntity.StartYDiff = Math.Round((((finDataEntity.StartY - finDataEntity.Price) / finDataEntity.Price) * 100) * 15, 4);
                finDataEntity.HighYDiff = Math.Round((((finDataEntity.HighY - finDataEntity.Price) / finDataEntity.Price) * 100) * 15, 4);
                finDataEntity.LowYDiff = Math.Round((((finDataEntity.LowY - finDataEntity.Price) / finDataEntity.Price) * 100) * 15, 4);
                finDataEntity.HighDDiff = Math.Round((((finDataEntity.HighD - finDataEntity.Price) / finDataEntity.Price) * 100) * 15, 4);
                finDataEntity.LowDDiff = Math.Round((((finDataEntity.LowD - finDataEntity.Price) / finDataEntity.Price) * 100) * 15, 4);

                var tempRegion = Regions[rng.Next(6)];
                finDataEntity.Region = tempRegion.RegionName;
                finDataEntity.Country = tempRegion.Countries[rng.Next(tempRegion.Countries.Length)];
                finDataEntity.ID = i;

                randomizeObjectData(finDataEntity);

                newData[i] = finDataEntity;
            }

            return newData;
        }

        /// <summary>
        /// Instead of returning a random date directly, why not return a generator function which can be called repeatedly to create a random date.
        /// You get a factory first: var getRandomDate = RandomDayFunc(); then you call it to get random dates: var randomDate = getRandomDate(); Mind that you need to reuse getRandomDate.
        /// </summary>
        /// <returns></returns>
        Func<DateTime> RandomDayFunc()
        {
            DateTime start = new DateTime(1995, 1, 1);
            Random gen = new Random();
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return () => start.AddDays(gen.Next(range));
        }

        /// <summary>
        /// Updates all Prices fields
        /// </summary>
        /// <param name="finData"></param>
        public void updateAllPrices(FinancialData[] finData)
        {
            Random rnd = new Random();
            for (int i = 0; i < finData.Length; i++)
            {
                randomizeObjectData(finData[rnd.Next(finData.Length)]);
            }
        }

        private void randomizeObjectData(FinancialData finDataObj)
        {
            PercentChange pc = generateNewPrice(finDataObj.Price);
            finDataObj.Change = Math.Round((pc.Price - finDataObj.Price), 4);
            finDataObj.Price = Math.Round(pc.Price, 4);
            finDataObj.ChangeP = Math.Round(pc.ChangePercent, 4);
        }

        private PercentChange generateNewPrice(double price)
        {
            Random rnd = new Random();
            int volatility = 2;
            double newPrice;

            double changePercent = 2 * volatility * rnd.Next(7);
            if (changePercent > volatility) {
                changePercent -= (2 * volatility);
            }

            double changeAmount = price * (changePercent / 100);
            newPrice = price + changeAmount;

            PercentChange result = new PercentChange();
            result.Price = Math.Round(newPrice, 4);
            result.ChangePercent = Math.Round(changePercent, 4);

            return result;
        }
    }
}
