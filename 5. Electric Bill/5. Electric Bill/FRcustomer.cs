using System;
using System.Collections.Generic;
using System.Text;

namespace _5._Electric_Bill
{
    class FRcustomer // foreign customer
    {
        // Properties
        private string ID;
        private string Name;
        private DateTime BillDate;
        private string Nationality;
        private int ElectricityUsed;
        private int Price;

        // Getters
        public string GetID() => this.ID;
        public string GetName() => this.Name;
        public DateTime GetBillDate() => this.BillDate;
        public string GetNationality() => this.Nationality;
        public int GetElectricityUsed() => this.ElectricityUsed;
        public int GetPrice() => this.Price;
        public double GetTotal() => this.ElectricityUsed * this.Price;

        // Constructor
        public FRcustomer(string id, string name, DateTime billDate, string nationality, int electricityUsed, int price)
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
            this.Name = name.Trim() == "" ? "#UNDEFINED" : name;
            this.BillDate = billDate == null ? default : billDate;
            this.Nationality = nationality.Trim() == "" ? "#UNDEFINED" : nationality;
            this.ElectricityUsed = electricityUsed > 0 ? electricityUsed : 0;
            this.Price = price > 0 ? price : 0;
        }
    }
}
