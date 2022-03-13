using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Library
{
    class ReferenceBook
    {
        // Properties
        private string ID;
        private DateTime ImportDate;
        private int Price;
        private int Amount;
        private string Publisher;
        private double Tax;

        // Setters
        public void SetID(string id)
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
        }
        public void SetImportDate(DateTime importDate)
        {
            this.ImportDate = importDate == null ? default : importDate;
        }
        public void SetPrice(int price)
        {
            this.Price = price > 0 ? price : 0;
        }
        public void SetAmount(int amount)
        {
            this.Amount = amount > 0 ? amount : 0;
        }
        public void SetPublisher(string publisher)
        {
            this.Publisher = publisher.Trim() == "" ? "#UNDEFINED" : publisher;
        }
        public void SetTax(double tax)
        {
            this.Tax = tax > 0 ? tax : 0;
        }

        // Getters
        public string GetID() => this.ID;
        public DateTime GetImportDate() => this.ImportDate;
        public int GetPrice() => this.Price;
        public int GetAmount() => this.Amount;
        public string GetPublisher() => this.Publisher;
        public double GetTax() => this.Tax;
        public double GetTotalPrice() => this.Amount * this.Price + this.Tax;

        // Constructor
        public ReferenceBook(string id, DateTime importDate, int price, int amount, string publisher, double tax)
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
            this.ImportDate = importDate == null ? default : importDate;
            this.Price = price > 0 ? price : 0;
            this.Amount = amount > 0 ? amount : 0;
            this.Publisher = publisher.Trim() == "" ? "#UNDEFINED" : publisher;
            this.Tax = tax > 0 ? tax : 0;
        }
    }
}
