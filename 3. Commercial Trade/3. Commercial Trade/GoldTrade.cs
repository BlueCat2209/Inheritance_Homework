using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Commercial_Trade
{
    class GoldTrade
    {
        // Properties
        private string ID;
        private DateTime TradeDate;
        private int Price;
        private int Amount;
        private string GoldType;

        // Getters
        public string GetID() => this.ID;
        public DateTime GetTradeDay() => this.TradeDate;
        public int GetPrice() => this.Price;
        public int GetAmount() => this.Amount;
        public string GetGoldType() => this.GoldType;
        public int GetTotal() => this.Amount * this.Price;

        // Constructor
        public GoldTrade(string id, DateTime tradeDate, int price, int amount, string goldType)
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
            this.TradeDate = tradeDate == null ? default : tradeDate;
            this.Price = price > 0 ? price : 0;
            this.Amount = amount > 0 ? amount : 0;
            this.GoldType = goldType.Trim() == "" ? "#UNDEFINED" : goldType;
        }
        
    }
}
