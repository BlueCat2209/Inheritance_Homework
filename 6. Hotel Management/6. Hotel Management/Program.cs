using System;

namespace _6._Hotel_Management
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("Bill Management");
            Console.WriteLine("===============");
            Console.WriteLine("1. Add bill.");
            Console.WriteLine("2. Get the number of Hours Bill in the list.");
            Console.WriteLine("3. Get the number of Days Bill in the list.");
            Console.WriteLine("4. Get the total money in this List.");
            Console.WriteLine("5. Print the List.");
            Console.WriteLine("6. Exit.");
            Console.WriteLine("===============");
            Console.WriteLine("Enter your command: ");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the max length of the bill: ");
            int maxLength = int.Parse(Console.ReadLine());
            Console.Clear();

            BillList billList = new BillList(maxLength);

            int command = 0;
            string id, customerName, roomID, billType;
            int day, month, year, price, countUsed;
            while (command != 6)
            {
                PrintMenu();
                command = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (command)
                {
                    case 1:
                        Console.WriteLine("Enter the information of the bill!");
                        Console.Write("Enter ID: ");
                        id = Console.ReadLine();
                        Console.Write("Enter bill's Day: ");
                        day = int.Parse(Console.ReadLine());
                        Console.Write("Enter bill's Month: ");
                        month = int.Parse(Console.ReadLine());
                        Console.Write("Enter bill's Year: ");
                        year = int.Parse(Console.ReadLine());
                        Console.Write("Enter customer's Name: ");
                        customerName = Console.ReadLine();
                        Console.Write("Enter Room ID: ");
                        roomID = Console.ReadLine();
                        Console.Write("Enter Room Price: ");
                        price = int.Parse(Console.ReadLine());
                        Console.Write("Enter bill type(Hour or Day): ");
                        billType = Console.ReadLine();
                        if (billType == "Hour") Console.Write("Enter the hours used: ");
                        else Console.Write("Enter the days used: ");
                        countUsed = int.Parse(Console.ReadLine());

                        if (billList.AddBill(id, new DateTime(year, month, day), customerName, roomID, price, countUsed, billType))
                        {
                            Console.WriteLine("The bill has been successfully added!");
                        }
                        else Console.WriteLine("The bill has not added into the List!");

                        break;
                    case 2:
                        Console.WriteLine($"The Hours Bill in the List is: {billList.GetNumberOfHoursBill()}");
                        break;
                    case 3:
                        Console.WriteLine($"The Days Bill in the List is: {billList.GetNumberOfDaysBill()}");
                        break;
                    case 4:
                        Console.WriteLine($"The total money has been made from this List is: {billList.GetTotal()}");
                        break;
                    case 5:
                        billList.PrintBills();
                        break;
                    case 6:
                        Console.WriteLine("Thank you for using my program!");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
