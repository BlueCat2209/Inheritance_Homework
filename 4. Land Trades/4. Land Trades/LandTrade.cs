using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Land_Trades
{
    class LandTrade
    {
        // Properties
        private string ID;
        private DateTime TradeDate;
        private int Price;
        private int Area;
        private string LandType;

        // Getters
        public string GetID() => this.ID;
        public DateTime GetTradeDate() => this.TradeDate;
        public int GetPrice() => this.Price;
        public int GetArea() => this.Area;
        public string GetLandType() => this.LandType;
        public double GetTotal() => this.LandType == "A" ? (this.Area * this.Price * 1.5) : (this.Area * this.Price);

        // Constructor
        public LandTrade(string id, DateTime tradeDate, int price, int area, string landType) 
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
            this.TradeDate = tradeDate != null ? tradeDate : default;
            this.Price = price > 0 ? price : 0;
            this.Area = area > 0 ? area : 0;
            this.LandType = ((landType == "A") || (landType == "B") || (landType == "C")) ? landType : "#UNDEFINED";
        }
    }
}
