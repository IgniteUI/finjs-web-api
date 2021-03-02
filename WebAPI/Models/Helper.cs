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

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
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

            for (int i = 0; i < newCount; i++)
            {
                var randomIndex = rng.Next(data.Length);
                // Copy object not by a reference
                newData[i] = copyObjectByValue(data[randomIndex]);
                // creates a number between 0 and 1
                newData[i].Settlement = Settlements[rng.Next(2)];
                newData[i].Contract = Contracts[rng.Next(5)];
                newData[i].LastUpdated = getRandomDate();
                newData[i].OpenPriceDiff = Math.Round((((newData[i].OpenPrice - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].BuyDiff = Math.Round((((newData[i].Buy - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].SellDiff = Math.Round((((newData[i].Sell - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].StartYDiff = Math.Round((((newData[i].StartY - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].HighYDiff = Math.Round((((newData[i].HighY - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].LowYDiff = Math.Round((((newData[i].LowY - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].HighDDiff = Math.Round((((newData[i].HighD - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].LowDDiff = Math.Round((((newData[i].LowD - newData[i].Price) / newData[i].Price) * 100) * 15, 4);

                var tempRegion = Regions[rng.Next(6)];
                newData[i].Region = tempRegion.RegionName;
                newData[i].Country = tempRegion.Countries[rng.Next(tempRegion.Countries.Length)];
                newData[i].ID = i;

                randomizeObjectData(newData[i]);
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

            double changePercent = 2 * volatility * rnd.NextDouble();
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

        /// <summary>
        /// Serializes and Deserializes object in order to copy it by value instead of reference
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private FinancialData copyObjectByValue(FinancialData obj)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            FinancialData newObj = Newtonsoft.Json.JsonConvert.DeserializeObject<FinancialData>(json);

            return newObj;
        }
    }
}
