using System;
using System.Collections.Generic;
using System.Text;

namespace _8._Person_Management
{
    class Employee : Person
    {
        // Properties
        private double SalaryRate;
        private double BasicSalary = 1500000;

        // Setter
        public void SetSalaryRate(double salaryRate) => this.SalaryRate = salaryRate > 0 ? salaryRate : 0;

        // Getters
        public double GetSalaryRate() => this.SalaryRate;
        public double GetBasicSalary() => this.BasicSalary;

        // Methods
        public double GetSalary() => this.SalaryRate * this.BasicSalary;
        public string GetRated() => (this.SalaryRate >= 3) ? "High" : ((this.SalaryRate >= 1.5) ? "Middle" : "Low");
        public override void InformationToString()
        {
            Console.WriteLine("=============");
            Console.WriteLine($"Name: {this.GetName()}");
            Console.WriteLine($"Address: {this.GetAddress()}");
            Console.WriteLine($"Salary: {GetSalary()}");
        }
        // Constructor
        public Employee(Person person, double salaryRate)
        {
            this.SetName(person.GetName());
            this.SetAddress(person.GetAddress());
            this.SetSalaryRate(salaryRate);
        }
    }
}
