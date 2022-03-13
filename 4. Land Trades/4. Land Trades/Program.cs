using System;

namespace _4._Land_Trades
{
    class Program
    {
        static void Main(string[] args)
        {
            LandTrade[] landTrades = new LandTrade[3];
            landTrades[0] = new LandTrade("Ninh Thuan", new DateTime(1, 1, 1), 10000000, 200, "A");
            landTrades[1] = new LandTrade("Ho Chi Minh", new DateTime(1, 1, 1), 50000000, 20, "B");
            landTrades[2] = new LandTrade("Binh Duong", new DateTime(1, 1, 1), 20000000, 50, "C");

            HouseTrade[] houseTrades = new HouseTrade[3];
            houseTrades[0] = new HouseTrade("Chung cu", new DateTime(1, 1, 1), "Quan 1", 1000000, 25, "High-class");
            houseTrades[1] = new HouseTrade("Nha dat", new DateTime(1, 1, 1), "Quan 2", 1500000, 70, "High-class");
            houseTrades[2] = new HouseTrade("Nha mini", new DateTime(1, 1, 1), "Quan 12", 500000, 50, "Normal-class");

            int landTradesArea = 0;
            foreach (LandTrade trade in landTrades)
            {
                landTradesArea += trade.GetArea();
            }
            int houseTradesArea = 0;
            foreach (HouseTrade trade in houseTrades)
            {
                houseTradesArea += trade.GetArea();
            }
            Console.WriteLine($"The total area of Land has been traded is: {landTradesArea}");
            Console.WriteLine($"The total area of House has been traded is: {houseTradesArea}");

            double averagePriceTrade = 0;
            foreach (LandTrade trade in landTrades)
            {
                averagePriceTrade += trade.GetPrice();
            }
            averagePriceTrade /= 3;
            Console.WriteLine($"The average price of land trades is: {averagePriceTrade:n2}");

            Console.Write("This is the IDs of all trade has been made in 1/1/1: ");
            foreach (LandTrade trade in landTrades)
            {
                if (trade.GetTradeDate() == new DateTime(1,1,1))
                {
                    Console.Write($"{trade.GetID()}, ");
                }
            }
            foreach (HouseTrade trade in houseTrades)
            {
                if (trade.GetTradeDate() == new DateTime(1, 1, 1))
                {
                    Console.Write($"{trade.GetID()}, ");
                }
            }
        }
    }
}
