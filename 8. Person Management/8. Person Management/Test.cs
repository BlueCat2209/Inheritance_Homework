using System;


namespace _8._Person_Management
{
    class Test
    {
        static void PrintMenu()
        {
            Console.WriteLine("PERSON MANAGEMENT");
            Console.WriteLine("=================");
            Console.WriteLine("1. Add a person.");
            Console.WriteLine("2. Delete a person.");
            Console.WriteLine("3. Sort List by name.");
            Console.WriteLine("4. Print List.");
            Console.WriteLine("5. Exit.");
            Console.WriteLine("=================");
            Console.Write("Enter your command: ");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the maximum length of the List: ");
            int maxLength = int.Parse(Console.ReadLine());
            Console.Clear();

            Management myManagement = new Management(maxLength);

            int command = 0;
            string name = "", address = "", type = "";
            while (command != 5)
            {
                PrintMenu();
                command = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (command)
                {
                    case 1:
                        Console.WriteLine("Person's Information");
                        Console.Write("Enter type: ");
                        type = Console.ReadLine();
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Address: ");
                        address = Console.ReadLine();
                        if (myManagement.Add(new Person(name, address), type))
                        {
                            Console.WriteLine("The Person has been successfully added into the List!");
                        }
                        else Console.Write("Fail to add the Person into the List!");
                        break;
                    case 2:
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();

                        myManagement.DeletePerson(name);
                        Console.WriteLine("The Person has been removed from the List!");
                        break;
                    case 3:
                        myManagement.SortListByName();
                        Console.WriteLine("The List has been sorted by name!");
                        break;
                    case 4:
                        myManagement.PrintList();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
