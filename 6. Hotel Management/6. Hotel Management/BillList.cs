using System;
using System.Collections.Generic;
using System.Text;

namespace _6._Hotel_Management
{
    class BillList
    {
        // Properties
        private Bill[] Bills;
        private int MaxLength;
        private int Count;
        private int NumberOfHoursBill;
        private int NumberOfDaysBill;

        // Getters
        public int GetMaxLength() => this.MaxLength;
        public int GetCount() => this.Count;
        public int GetNumberOfHoursBill() => this.NumberOfHoursBill;
        public int GetNumberOfDaysBill() => this.NumberOfDaysBill;
        public double GetTotal()
        {
            double total = 0;
            for (int i = 0; i < this.Count; i++)
            {
                total += this.Bills[i].GetTotal();                                                                                                                                                            
            }
            return total;
        }

        // Methods
        public int Find(string id)
        {
            for (int i = 0; i <= Count; i++)
            {
                if (this.Bills[i].GetID() == id) return i;
            }
            return -1;
        }
        public bool AddBill(string id, DateTime billDate, string customerName, string roomID, int price, int countUsed, string billType)
        {
            if (this.Find(id) >= 0) return false;

            if (billType == "Hour") this.NumberOfHoursBill++;
            else this.NumberOfDaysBill++;
            this.Bills[this.Count++] = new Bill(id, billDate, customerName, roomID, price, countUsed, billType);                                            
            return true;
        }
        public void PrintBills() // Need to be fixing!!!
        {
            Console.WriteLine("|ID   |Date      |Customer's Name     |Room ID |Price |Used |Type |");
            for (int i = 0; i < this.Count; i++)
            {
                Console.WriteLine($"|{this.Bills[i].GetID(),-5}|{this.Bills[i].GetBillDate(),-10:d}|{this.Bills[i].GetCustomerName(),-20}|{this.Bills[i].GetRoomID(),8}|{this.Bills[i].GetPrice(),6}|{this.Bills[i].GetCountUsed(),5}|{this.Bills[i].GetBillType(),5}|");
                              
            }
        }

        // Constructor
        public BillList(int maxLength)
        {
            this.Bills = new Bill[maxLength];
            this.Bills[0] = new Bill();
            this.MaxLength = maxLength;
            this.Count = 0;
            this.NumberOfDaysBill = 0;
            this.NumberOfHoursBill = 0;
        }
    }
}
