using System;
using System.Collections.Generic;
using System.Text;

namespace _7._Production
{
    class Food : Product
    {
        // Properties
        private string Producer;
        private DateTime ManufactureDate;
        private DateTime ExpirationDate;

        // Setters
        public void SetProducer(string producer) => this.Producer = producer.Trim() == "" ? "#UNDEFINED" : producer;
        public void SetManufactureDate(DateTime manufactureDate) => this.ManufactureDate = manufactureDate.Date <= DateTime.Now ? manufactureDate : DateTime.Now;
        public void SetExprirationDate(DateTime expirationDate) => this.ExpirationDate = expirationDate.Date >= this.ManufactureDate.Date ? expirationDate : this.ManufactureDate.Date;

        // Getters
        public string GetProducer() => this.Producer;
        public DateTime GetManufactureDate() => this.ManufactureDate;
        public DateTime GetExprirationDate() => this.ExpirationDate;
        public double GetVATtax(double VATrate) => this.GetPrice() * VATrate;
        public string GetSellingStatus() => ((this.GetAmount() > 0) & (this.GetExprirationDate() >= DateTime.Now)) ? "Hard-Selling" : "Normal";

        // Method
        public override void PrintProduct()
        {
            Console.WriteLine("======================");
            Console.WriteLine($"ID: {this.GetID()}");
            Console.WriteLine($"Name: {this.GetName()}");
            Console.WriteLine($"Price: {this.GetPrice()}");
            Console.WriteLine($"Amount: {this.GetAmount()}");
            Console.WriteLine($"Producer: {this.GetProducer()}");
            Console.WriteLine($"Manufacture Date: {this.GetManufactureDate():d}");
            Console.WriteLine($"Expiration Date: {this.GetExprirationDate():d}");
        }

        // Constructor
        public Food(string id, string name, int price, int amount, string producer, DateTime manufactureDate, DateTime expirationDate)
        {
            this.SetID(id);
            this.SetName(name);
            this.SetPrice(price);
            this.SetAmount(amount);
            this.SetProducer(producer);
            this.SetManufactureDate(manufactureDate);
            this.SetExprirationDate(expirationDate);
        }
    }
}
