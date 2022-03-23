using System;
using System.Collections.Generic;
using System.Text;

namespace _7._Production
{

    class Product 
    {
        // Comparer
        public class NameComparer : IComparer<Product>
        {
            public int Compare(Product a, Product b)
            {
                return a.GetName().CompareTo(b.GetName());
            }
        }
        public class AmountComparer 
        {
            public int Compare(Product a, Product b)
            {
                return a.GetAmount().CompareTo(b.GetAmount());
            }
        }

        // Properties
        private string ID;
        private string Name;
        private int Price;
        private int Amount;

        // Setters
        public void SetID(string id) => this.ID = id.Trim() == "" ? "#UNDEFINED" : id;
        public void SetName(string name) => this.Name= name.Trim() == "" ? "#UNDEFINED" : name;
        public void SetPrice(int price) => this.Price = price > 0 ? price : 0;
        public void SetAmount(int amount) => this.Amount = amount > 0 ? amount : 0;

        // Getters
        public string GetID() => this.ID;
        public string GetName() => this.Name;
        public int GetPrice() => this.Price;
        public int GetAmount() => this.Amount;

        // Constructor
        public Product()
        {
            this.ID = "#UNDEFINED";
            this.Name = "#UNDEFINED";
            this.Price = 0;
            this.Amount = 0;
        }
        public Product(string id, string name, int price, int amount)
        {
            this.SetID(id);
            this.SetName(name);
            this.SetPrice(price);
            this.SetAmount(amount);
        }
    }
}
