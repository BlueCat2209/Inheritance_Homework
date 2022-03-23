using System;
using System.Collections.Generic;
using System.Text;

namespace _5._Electric_Bill
{
    class VNCustomer
    {
        // Properties
        private string ID;
        private string Name;
        private DateTime BillDate;
        private int ElectricityUsed;
        private int ElectricityQuota;
        private int Price;
        private string CustomerType; // Household || Business || Manufacture

        // Getters
        public string GetID() => this.ID;
        public string GetName() => this.Name;
        public DateTime GetBillDate() => this.BillDate;
        public int GetElectricityUsed() => this.ElectricityUsed;
        public int GetElectricityQuota() => this.ElectricityQuota;
        public int GetPrice() => this.Price;
        public string GetCustomerType() => this.CustomerType;
        public double GetTotal() 
            => this.ElectricityQuota >= this.ElectricityUsed ? 
            (this.Price * this.ElectricityUsed) : (this.Price * this.ElectricityQuota + this.Price * 2.5 * (this.ElectricityUsed - this.ElectricityQuota));
            // Normal price                                                                         the over-quota will be more expensive than normal 2.5 times

        // Contructor
        public VNCustomer(string id, string name, DateTime billDate, int electricityUsed, int electricityQuota, int price, string customerType)
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
            this.Name = name.Trim() == "" ? "#UNDEFINED" : name;
            this.BillDate = billDate == null ? default : billDate;
            this.ElectricityUsed = electricityUsed > 0 ? electricityUsed : 0;
            this.ElectricityQuota = electricityQuota > 0 ? electricityQuota : 0;
            this.Price = price > 0 ? price : 0;
            this.CustomerType = ((customerType == "Household") || (customerType == "Business") || (customerType == "Manufacture")) ? customerType : "#UNDEFINED";
        }
    }
}
