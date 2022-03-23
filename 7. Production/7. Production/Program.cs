using System;

namespace _7._Production
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("Product Management");
            Console.WriteLine("==================");
            Console.WriteLine("1. Add a product.");
            Console.WriteLine("2. Find a product.");
            Console.WriteLine("3. Edit a product's information.");
            Console.WriteLine("4. Delete a product.");
            Console.WriteLine("5. Print Ceramic product.");
            Console.WriteLine("6. Print Food product.");
            Console.WriteLine("7. Print Electronic product.");
            Console.WriteLine("8. Print Hard-Selling product.");
            Console.WriteLine("9. Print Product list.");
            Console.WriteLine("10. Sort the List by Name.");
            Console.WriteLine("11. Sort the List by Product's Amount.");
            Console.WriteLine("12. Exit.");
            Console.WriteLine("==================");
            Console.WriteLine("Enter your command: ");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the maximum product of the List: ");
            int maxLength = int.Parse(Console.ReadLine());
            Console.Clear();

            ProductList myList = new ProductList(maxLength);

            int command = 0; 
            int price = 0; int amount = 0;
            string type = ""; string id = ""; string name = "";
            Product product;
            while (command != 12)
            {
                PrintMenu();
                command = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (command)
                {
                    case 1:
                        Console.WriteLine("Product's Information:");

                        Console.Write("Enter ID: ");
                        id = Console.ReadLine();
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        price = int.Parse(Console.ReadLine());
                        Console.Write("Enter Amount: ");
                        amount = int.Parse(Console.ReadLine());

                        product = new Product(id, name, price, amount);

                        Console.Write("Enter Product's type: ");
                        type = Console.ReadLine();

                        myList.AddProduct(product, type);
                        break;
                    case 2:
                        Console.Write("Enter product's ID: ");
                        id = Console.ReadLine();
                        myList.PrintProduct(id);
                        break;
                    case 3:
                        Console.Write("Enter Product's ID: ");
                        id = Console.ReadLine();
                        
                        Console.WriteLine("Product's Information edit:");
                        Console.Write("Enter ID: ");
                        id = Console.ReadLine();
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        price = int.Parse(Console.ReadLine());
                        Console.Write("Enter Amount: ");
                        amount = int.Parse(Console.ReadLine());

                        product = new Product(id, name, price, amount);
                        myList.EditInfoProduct(id, product);
                        break;
                    case 4:
                        Console.Write("Enter Product's ID: ");
                        id = Console.ReadLine();

                        myList.DeleteProduct(id);
                        break;
                    case 5:
                        myList.PrintCeramic();
                        break;
                    case 6:
                        myList.PrintFood();
                        break;
                    case 7:
                        myList.PrintElectronic();
                        break;
                    case 8:
                        myList.PrintHardSelling();
                        break;
                    case 9:
                        myList.PrintList();
                        break;
                    case 10:
                        myList.SortListbyName();
                        Console.WriteLine("The List has been sorted by Name!");
                        break;
                    case 11:
                        myList.SortListbyAmount();
                        Console.WriteLine("The List has been sorted by Amount!");
                        break;
                }
                Console.Clear();
                Console.ReadKey();
            }
        }
    }
}
