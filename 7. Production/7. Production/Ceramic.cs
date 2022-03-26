using System;
using System.Collections.Generic;
using System.Text;

namespace _7._Production
{
    class Ceramic : Product
    {
        // Properties
        private string Producer;
        private DateTime ReceiveDate;
        private TimeSpan RateDate = new TimeSpan(10, 0, 0, 0);

        // Setters
        public void SetProducer(string producer) => this.Producer = producer.Trim() == "" ? "#UNDEFINED" : producer;
        public void SetReceiveDate(DateTime receiveDate) => this.ReceiveDate = receiveDate.Date <= DateTime.Now ? receiveDate : DateTime.Now;

        // Getters
        public string GetProducer() => this.Producer;
        public DateTime GetReceiveDate() => this.ReceiveDate;
        public double GetVATtax(double VATrate) => this.GetPrice() * VATrate;
        public string GetSellingStatus() => ((this.GetAmount() > 50) & ((DateTime.Now - this.GetReceiveDate()) > this.RateDate)) ? "Slow-Selling" : "Normal";

        // Method
        public override void PrintProduct()
        {
            Console.WriteLine("======================");
            Console.WriteLine($"ID: {this.GetID()}");
            Console.WriteLine($"Name: {this.GetName()}");
            Console.WriteLine($"Price: {this.GetPrice()}");
            Console.WriteLine($"Amount: {this.GetAmount()}");
            Console.WriteLine($"Producer: {this.GetProducer()}");
            Console.WriteLine($"Receive Date: {this.GetReceiveDate():d}");
        }

        // Constructor
        public Ceramic(string id, string name, int price, int amount, string producer, DateTime receiveDate)
        {
            this.SetID(id);
            this.SetName(name);
            this.SetPrice(price);
            this.SetAmount(amount);
            this.SetProducer(producer);
            this.SetReceiveDate(receiveDate);
        }
    }
}
