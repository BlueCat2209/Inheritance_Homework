using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Land_Trades
{
    class HouseTrade
    {
        // Properties
        private string ID;
        private DateTime TradeDate;
        private string Address;
        private int Price;
        private int Area;
        private string HouseType; // There are just two values: High-class || Normal-class

        // Getters
        public string GetID() => this.ID;
        public DateTime GetTradeDate() => this.TradeDate;
        public string GetAddress() => this.Address;
        public int GetPrice() => this.Price;
        public int GetArea() => this.Area;
        public string GetHouseType() => this.HouseType;
        public double GetTotal() => this.HouseType == "High-class" ? (this.Area * this.Price) : (this.Area * this.Price * 0.9);

        // Constructor
        public HouseTrade(string id, DateTime tradeDate, string address, int price, int area, string houseType)
        {
            this.ID = id.Trim() != "" ? id : "#UNDEFINED";
            this.TradeDate = tradeDate != null ? tradeDate : default;
            this.Address = address.Trim() != "" ? address : "#UNDEFINED";
            this.Price = price > 0 ? price : 0;
            this.Area = area > 0 ? area : 0;
            this.HouseType = ((houseType == "High-class") || (houseType == "Normal-class")) ? houseType : "#UNDEFINED";
        }
    }
}
