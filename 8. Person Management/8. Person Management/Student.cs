using System;
using System.Collections.Generic;
using System.Text;

namespace _8._Person_Management
{
    class Student : Person
    {
        // Properties
        private double Score1;
        private double Score2;

        // Setters
        public void SetScore1(double score1) => this.Score1 = score1 > 0 ? score1 : 0;
        public void SetScore2(double score2) => this.Score2 = score2 > 0 ? score2 : 0;

        // Getters
        public double GetScore1() => this.Score1;
        public double GetScore2() => this.Score2;

        // Methods
        public double GetAverageScore() => (this.Score1 + this.Score2) / 2;
        public string GetRated() => (this.GetAverageScore() >= 8) ? "Good" 
                                    : ((this.GetAverageScore() >= 6.5) ? "Normal" 
                                    : ((this.GetAverageScore() >= 5) ? "Low" : "Bad"));
        public override void InformationToString() 
        {
            Console.WriteLine("=============");
            Console.WriteLine($"Name: {this.GetName()}");
            Console.WriteLine($"Address: {this.GetAddress()}");
            Console.WriteLine($"Average Score: {this.GetAverageScore()}");       
        }

        // Constructor
        public Student(Person person, double score1, double score2)
        {
            this.SetName(person.GetName());
            this.SetAddress(person.GetAddress());
            this.SetScore1(score1);
            this.SetScore2(score2);
        }
    }
}
