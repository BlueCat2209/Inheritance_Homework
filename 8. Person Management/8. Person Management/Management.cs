using System;
using System.Collections.Generic;
using System.Text;

namespace _8._Person_Management
{
    class Management
    {
        // Properties
        private Person[] List;
        private int MaxLength;
        private int Count;

        // Methods
        public int Find(string name)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (name == this.List[i].GetName())
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Add(Person person, string type)
        {
            if ((Count == MaxLength) || (this.Find(person.GetName()) >= 0)) return false;
            switch(type)
            {
                case "Student":
                    Console.Write("Enter Score1: ");
                    double score1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter Score2: ");
                    double score2 = double.Parse(Console.ReadLine());

                    this.List[this.Count++] = new Student(person, score1, score2);
                    break;
                case "Employee":
                    Console.Write("Enter Salary Rate: ");
                    double salaryRate = double.Parse(Console.ReadLine());

                    this.List[this.Count++] = new Employee(person, salaryRate);
                    break;
                case "Customer":
                    Console.Write("Enter Company Name: ");
                    string companyName = Console.ReadLine();
                    Console.Write("Enter total bill: ");
                    int totalBill = int.Parse(Console.ReadLine());
                    Console.Write("Enter Rate: ");
                    string rate = Console.ReadLine();

                    this.List[this.Count++] = new Customer(person, companyName, totalBill, rate);
                    break;
            }
            return true;
        }
        public void DeletePerson(string name)
        {
            Person[] tmp = new Person[MaxLength];
            for (int i = 0, j = 0; i < this.Count; i++, j++)
            {
                if (this.List[i].GetName() == name)
                {
                    i++;
                }
                tmp[j] = this.List[i];
            }
            this.List = tmp;
        }
        public void SortListByName()
        {
            Array.Sort(this.List, new Person.NameCompare());
        }
        public void PrintList()
        {
            foreach (Person person in this.List)
            {
                if (person is Student)
                {
                    Student student = (Student)person;
                    student.InformationToString();
                }    
                else if (person is Employee)
                {
                    Employee employee = (Employee)person;
                    employee.InformationToString();
                }
                else if (person is Customer)
                {
                    Customer customer = (Customer)person;
                    customer.InformationToString();
                }
            }
        }

        // Constructor
        public Management(int maxLength)
        {
            this.List = new Person[maxLength];
            this.MaxLength = maxLength > 0 ? maxLength : 0;
            this.Count = 0;
        }
    }
}
