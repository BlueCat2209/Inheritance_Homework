using System;
using System.Collections.Generic;
using System.Text;

namespace _8._Person_Management
{
    class Person
    {
        public class NameCompare : IComparer<Person>
        {
            public int Compare(Person a, Person b)
            {
                return a.GetName().CompareTo(b.GetName());
            }
        }

        // Properties
        private string Name;
        private string Address;

        // Setters
        public void SetName(string name) => this.Name = name.Trim() == "" ? "#UNDEFINED" : name;
        public void SetAddress(string address) => this.Address = address.Trim() == "" ? "#UNDEFINED" : address;

        // Getters
        public string GetName() => this.Name;
        public string GetAddress() => this.Address;

        // Method
        public virtual void InformationToString()
        {
            Console.WriteLine("=============");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Address: {this.Address}");
        }

        // Constructor
        public Person()
        {
            this.Name = "#UNDEFINED";
            this.Address = "#UNDEFINED";
        }
        public Person(string name, string address)
        {
            this.Name = name.Trim() == "" ? "#UNDEFINED" : name;
            this.Address = address.Trim() == "" ? "#UNDEFINED" : address;
        }
    }
}
