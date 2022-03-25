using System;
using System.Collections.Generic;
using System.Text;

namespace _8._Person_Management
{
    class Customer : Person
    {
        // Properties
        private string CompanyName;
        private int TotalBill;
        private string Rate;

        // Setters
        public void SetCompanyName(string companyName) => this.CompanyName = companyName.Trim() == "" ? "#UNDEFINED" : companyName;
        public void SetTotalBill(int totalBill) => this.TotalBill = totalBill > 0 ? totalBill : 0;
        public void SetRate(string rate) => this.Rate = rate.Trim() == "" ? "#UNDEFINED" : rate;

        // Getters
        public string GetCompanyName() => this.CompanyName;
        public int GetTotalBill() => this.TotalBill;
        public string GetRate() => this.Rate;

        // Method
        public override void InformationToString()
        {
            Console.WriteLine("=============");
            Console.WriteLine($"Name: {this.GetName()}");
            Console.WriteLine($"Address: {this.GetAddress()}");
            Console.WriteLine($"Company Name: {this.GetCompanyName()}");
            Console.WriteLine($"Total Bill: {this.GetTotalBill()}");
            Console.WriteLine($"Rate: {this.GetRate()}");
        }

        // Constructor
        public Customer(Person person, string companyName, int totalBill, string rate)
        {
            this.SetName(person.GetName());
            this.SetAddress(person.GetAddress());
            this.SetCompanyName(companyName);
            this.SetTotalBill(totalBill);
            this.SetRate(rate);
        }
    }
}
