using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Commercial_Trade
{
    class CurrencyTrade
    {
        // Properties
        private string ID;
        private DateTime TradeDate;
        private int Price;
        private int Amount;
        private int ExchangeRate;
        private string Currency;

        // Getters
        public string GetID() => this.ID;
        public DateTime GetTradeDate() => this.TradeDate;
        public int GetPrice() => this.Price;
        public int GetAmount() => this.Amount;
        public int GetExchangeRate() => this.ExchangeRate;
        public string GetCurrency() => this.Currency;
        public int GetTotal() => (this.Currency == "VND" ? (this.Amount * this.Price) : (this.Currency != "#UNDEFINED" ? (this.Amount * this.Price * this.ExchangeRate) : -1));
        
        // Contructor
        public CurrencyTrade(string id, DateTime tradeDate, int price,int amount,int exchangeRate, string currency)
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
            this.TradeDate = tradeDate == null ? default : tradeDate;
            this.Price = price > 0 ? price : 0;
            this.Amount = amount > 0 ? amount : 0;
            this.ExchangeRate = exchangeRate > 0 ? exchangeRate : 0;
            this.Currency = currency.Trim() == "" ? "#UNDEFINED" : currency;
        }
    }
}
