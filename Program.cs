using System;
using System.Collections.Generic;
using System.Globalization;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("GE", "General Electric");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("APPL", "Apple");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GE", shares: 150, price: 237.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 16.02));
            purchases.Add((ticker: "APPL", shares: 88, price: 423.21));
            purchases.Add((ticker: "APPL", shares: 43, price: 217.87));
            purchases.Add((ticker: "APPL", shares: 78, price: 719.02));
            purchases.Add((ticker: "GM", shares: 15, price: 23.21));
            purchases.Add((ticker: "GM", shares: 329, price: 11.87));
            purchases.Add((ticker: "GM", shares: 801, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 1570, price: 44.21));
            purchases.Add((ticker: "CAT", shares: 3255, price: 17.87));
            purchases.Add((ticker: "CAT", shares: 806, price: 195.02));

            Dictionary<string, double> portfolio = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (stocks.ContainsKey(purchase.ticker))
                {
                    if (portfolio.ContainsKey(stocks[purchase.ticker]))
                    {
                        portfolio[stocks[purchase.ticker]] += (purchase.shares * purchase.price);
                    }
                    else
                    {
                        portfolio[stocks[purchase.ticker]] = (purchase.shares * purchase.price);
                    }

                    // Does the company name key already exist in the report dictionary?

                    // If it does, update the total valuation

                    // If not, add the new key and set its value
                }

            }

            Console.WriteLine("Your Portfolio Contains:");
            foreach (KeyValuePair<string, double> item in portfolio)
            {
                Console.WriteLine($"{item.Value.ToString("C", new CultureInfo("en-US"))} of {item.Key}");
            }
        }
    }
}
