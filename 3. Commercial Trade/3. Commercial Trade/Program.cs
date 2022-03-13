using System;

namespace _3._Commercial_Trade
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldTrade[] goldTrades = new GoldTrade[3];
            goldTrades[0] = new GoldTrade("Thuan", new DateTime(1, 1, 1), 100000, 2, "G-999");
            goldTrades[1] = new GoldTrade("Thanh", new DateTime(1, 1, 1), 50000, 2, "G-997");
            goldTrades[2] = new GoldTrade("Khanh", new DateTime(1, 1, 1), 10000, 10, "G-Fake");

            CurrencyTrade[] currencyTrades = new CurrencyTrade[3];
            currencyTrades[0] = new CurrencyTrade("Tom", new DateTime(1, 1, 1), 10, 1, 20000, "USD");
            currencyTrades[1] = new CurrencyTrade("Tim", new DateTime(1, 1, 1), 25, 2, 20000, "USD");
            currencyTrades[2] = new CurrencyTrade("Lyi", new DateTime(1, 1, 1), 20, 3, 25000, "EUR");

            int countGoldTrades = 0;
            foreach (GoldTrade trade in goldTrades)
            {
                countGoldTrades += trade.GetAmount();
            }
            int countCurrencyTrades = 0;
            foreach (CurrencyTrade trade in currencyTrades)
            {
                countCurrencyTrades += trade.GetAmount();
            }
            Console.WriteLine($"The number of trades has been make by Gold is: {countGoldTrades}");
            Console.WriteLine($"The number of trades has been make by Currency is: {countCurrencyTrades}");

            double averageTrade = 0;
            foreach (CurrencyTrade trade in currencyTrades)
            {
                averageTrade += trade.GetTotal();
            }
            averageTrade /= currencyTrades.Length;
            Console.WriteLine($"The average trade of total trade by Currency is: {averageTrade}");

            Console.Write("This is IDs of trades with the total greater than 1 hundred VND: ");
            foreach (GoldTrade trade in goldTrades)
            {
                if (trade.GetTotal() > 100000)
                {
                    Console.Write($"{trade.GetID()}, ");
                }
            }
            foreach (CurrencyTrade trade in currencyTrades)
            {
                if (trade.GetTotal() > 100000)
                {
                    Console.Write($"{trade.GetID()}, ");
                }
            }
        }
    }
}
