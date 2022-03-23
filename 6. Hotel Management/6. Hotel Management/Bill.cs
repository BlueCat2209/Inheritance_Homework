using System;
using System.Collections.Generic;
using System.Text;

namespace _6._Hotel_Management
{
    class Bill
    {
        // Properties
        private string ID;
        private DateTime BillDate;
        private string CustomerName;
        private string RoomID;
        private int Price;
        private int CountUsed;
        private string BillType;

        // Setters
        public void SetID(string id)
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
        }
        public void SetBillDate(DateTime billDate)
        {
            this.BillDate = billDate == null ? default : billDate;
        }
        public void SetCustomerName(string customerName)
        {
            this.CustomerName = customerName.Trim() == "" ? "#UNDEFINED" : customerName;
        }
        public void SetRoomID(string roomID)
        {
            this.RoomID = roomID.Trim() == "" ? "#UNDEFINED" : roomID;
        }
        public void SetPrice(int price)
        {
            this.Price = price > 0 ? price : 0;
        }
        public void SetCountUsed(int countUsed)
        {
            this.CountUsed = countUsed > 0 ? countUsed : 0;
        }
        public void SetBillType(string billType)
        {
            this.BillType = billType;
        }

        // Getters
        public string GetID() => this.ID;
        public DateTime GetBillDate() => this.BillDate;
        public string GetCustomerName() => this.CustomerName;
        public string GetRoomID() => this.RoomID;
        public int GetPrice() => this.Price;
        public int GetCountUsed() => this.CountUsed;
        public string GetBillType() => this.BillType;
        public double GetTotal()
        {
            if (this.BillType == "Day")
            {
                return this.CountUsed <= 7 ?
                       (this.GetPrice() * this.GetCountUsed()) : (this.GetPrice() * 7 + this.GetPrice() * 0.2 * (this.GetCountUsed() - 7));
            }
            else // BillType == "Hour"
            {
                return this.CountUsed <= 24 ?
                       (this.GetCountUsed() * this.GetPrice()) : (this.GetCountUsed() <= 30 ? (this.GetPrice() * 24) : (-1));
            }
        }

        // Constructors
        public Bill() // Default constructor 
        {
            this.ID = "#UNDEFINED";
            this.BillDate = default;
            this.CustomerName = "#UNDEFINED";
            this.RoomID = "#UNDEFINED";
            this.Price = 0;
        }
        public Bill(string id, DateTime billDate, string customerName, string roomID, int price, int countUsed, string billType)
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
            this.BillDate = billDate == null ? default : billDate;
            this.CustomerName = customerName.Trim() == "" ? "#UNDEFINED" : customerName;
            this.RoomID = roomID.Trim() == "" ? "#UNDEFINED" : roomID;
            this.Price = price > 0 ? price : 0;
            this.CountUsed = countUsed > 0 ? countUsed : 0;
            this.BillType = billType.Trim() == "" ? "#UNDEFINED" : billType;
        }
    }
}
