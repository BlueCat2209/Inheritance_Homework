using System;
using System.Collections.Generic;
using System.Text;

namespace _7._Production
{
    class Electronic : Product
    {
        // Properties
        private int InsuranceMonth;
        private int Wattage;


        // Setters
        public void SetInsuranceMonth(int insuranceMonth) => this.InsuranceMonth = insuranceMonth > 0 ? insuranceMonth : 0;
        public void SetWattage(int wattage) => this.Wattage = wattage > 0 ? wattage : 0;

        // Getters
        public int GetInsuranceMonth() => this.InsuranceMonth;
        public int GetWattage() => this.Wattage;
        public double GetVATtax(double VATrate) => this.GetPrice() * VATrate;
        public string GetSellingStatus() => this.GetAmount() < 3 ? "Good-Selling" : "Normal";

        // Method
        public void PrintProduct()
        {
            Console.WriteLine("======================");
            Console.WriteLine($"ID: {this.GetID()}");
            Console.WriteLine($"Name: {this.GetName()}");
            Console.WriteLine($"Price: {this.GetPrice()}");
            Console.WriteLine($"Amount: {this.GetAmount()}");
            Console.WriteLine($"Insurance Month: {this.GetInsuranceMonth()}");
            Console.WriteLine($"Wattage: {this.GetWattage()}");
        }

        // Constructor
        public Electronic(string id, string name, int price, int amount, int insuranceMonth, int wattage)
        {
            this.SetID(id);
            this.SetName(name);
            this.SetPrice(price);
            this.SetAmount(amount);
            this.SetInsuranceMonth(insuranceMonth);
            this.SetWattage(wattage);
        }
    }
}
