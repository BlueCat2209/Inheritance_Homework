using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Library
{
    class TextBook
    {
        // Properties
        private string ID;
        private DateTime ImportDate;
        private int Price;
        private int Amount;
        private string Publisher;
        private bool Status;

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
        public void SetStatus(bool status)
        {
            this.Status = status;
        } // true: new; false: old

        // Getters
        public string GetID() => this.ID;
        public DateTime GetImportDate() => this.ImportDate;
        public int GetPrice() => this.Price;
        public int GetAmount() => this.Amount;
        public string GetPublisher() => this.Publisher;
        public bool GetStatus() => this.Status;
        public double GetTotalPrice() => this.Status ? (this.Price * this.Amount) : (this.Price * this.Amount * 0.5);

        // Constructor
        public TextBook(string id, DateTime importDate, int price, int amount, string publisher, bool status)
        {
            this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
            this.ImportDate = importDate == null ? default : importDate;
            this.Price = price > 0 ? price : 0;
            this.Amount = amount > 0 ? amount : 0;
            this.Publisher = publisher.Trim() == "" ? "#UNDEFINED" : publisher;
            this.Status = status;
        }
    }
}
