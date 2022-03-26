using System;
using System.Collections.Generic;
using System.Text;

namespace _7._Production
{
    class ProductList
    {
        // Properties
        private Product[] List;
        private int Count;
        private int MaxLength;

        // Setters

        // Getters


        // Methods
        public int Find(string id)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.List[i].GetID() == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool AddProduct(Product product, string type)
        {
            if (this.Count == this.MaxLength)
            {
                Console.WriteLine("The List has been fully added!");
                return false;
            }
            else if (this.Find(product.GetID()) >= 0)
            {
                Console.WriteLine("This Product's ID has been added into the List before!");
                return false;
            }
            else
            {
                int day = 0; 
                int year = 0; 
                int month = 0;
                int insuranceMonth = 0;
                int wattage = 0;
                string producer = "";

                switch(type)
                {
                    case "Food":
                        Console.Write("Enter Producer: ");
                        producer = Console.ReadLine();

                        Console.WriteLine("Manufacture Date:");
                        Console.Write("Enter Day: ");
                        day = int.Parse(Console.ReadLine());
                        Console.Write("Enter Month: ");
                        month = int.Parse(Console.ReadLine());
                        Console.Write("Enter Year: ");
                        year = int.Parse(Console.ReadLine());
                        DateTime manufactureDate = new DateTime(year, month, day);
                        
                        Console.WriteLine("Expiration Date:");
                        Console.Write("Enter Day: ");
                        day = int.Parse(Console.ReadLine());
                        Console.Write("Enter Month: ");
                        month = int.Parse(Console.ReadLine());
                        Console.Write("Enter Year: ");
                        year = int.Parse(Console.ReadLine());
                        DateTime expirationDate = new DateTime(year, month, day);

                        this.List[this.Count++] = new Food(product.GetID(), product.GetName(), product.GetPrice(), product.GetAmount(), producer, manufactureDate, expirationDate);
                        break;
                    case "Ceramic":
                        Console.Write("Enter Producer: ");
                        producer = Console.ReadLine();

                        Console.WriteLine("Receive Date:");                        
                        Console.Write("Enter Day: ");
                        day = int.Parse(Console.ReadLine());
                        Console.Write("Enter Month: ");
                        month = int.Parse(Console.ReadLine());
                        Console.Write("Enter Year: ");
                        year = int.Parse(Console.ReadLine());
                        DateTime receiveDate = new DateTime(year, month, day);

                        this.List[this.Count++] = new Ceramic(product.GetID(), product.GetName(), product.GetPrice(), product.GetAmount(), producer, receiveDate);
                        break;
                    case "Electronic":
                        Console.Write("Enter Insurance Months: ");
                        insuranceMonth = int.Parse(Console.ReadLine());
                        Console.Write("Enter Product's Wattage: ");
                        wattage = int.Parse(Console.ReadLine());

                        this.List[this.Count++] = new Electronic(product.GetID(), product.GetName(), product.GetPrice(), product.GetAmount(), insuranceMonth, wattage);
                        break;
                }

                Console.WriteLine("This Product has been added successfully into the List!");
                return true;
            }
        }

        public void PrintList()
        {
            for (int i=0; i < this.Count; i++)
            {
                if (this.List[i] is Food)
                {
                    Food food = (Food)this.List[i];
                    food.PrintProduct();
                }
                else if (this.List[i] is Ceramic)
                {
                    Ceramic ceramic = (Ceramic)this.List[i];
                    ceramic.PrintProduct();
                }
                else if (this.List[i] is Electronic)
                {
                    Electronic electronic = (Electronic)this.List[i];
                    electronic.PrintProduct();
                }
            }
        }
        public void PrintProduct(string id)
        {
            int i = this.Find(id);
            if (this.Find(id) >= 0)
            {
                if (this.List[i] is Food)
                {
                    Food food = (Food)this.List[i];
                    food.PrintProduct();
                }
                else if (this.List[i] is Ceramic)
                {
                    Ceramic ceramic = (Ceramic)this.List[i];
                    ceramic.PrintProduct();
                }
                else if (this.List[i] is Electronic)
                {
                    Electronic electronic = (Electronic)this.List[i];
                    electronic.PrintProduct();
                }
            }
            else
            {
                Console.WriteLine("There is no product with this ID in the List!");
            }
        }
        public void PrintFood()
        {
            foreach (Product product in this.List)
            {
                if (product is Food)
                {
                    Food food = (Food)product;
                    food.PrintProduct();
                }
            }
        }
        public void PrintCeramic()
        {
            foreach (Product product in this.List)
            {
                if (product is Ceramic)
                {
                    Ceramic ceramic = (Ceramic)product;
                    ceramic.PrintProduct();
                }
            }
        }
        public void PrintElectronic()
        {
            foreach (Product product in this.List)
            {
                if (product is Electronic)
                {
                    Electronic electronic = (Electronic)product;
                    electronic.PrintProduct();
                }
            }
        }
        public void PrintHardSelling()
        {
            foreach (Product product in this.List)
            {
                if (product is Food)
                {
                    Food food = (Food)product;
                    if (food.GetSellingStatus() == "Hard-Selling")
                    {
                        food.PrintProduct();
                    }
                }
            }
        }

        public void DeleteProduct(string id)
        {
            Product[] tmp = new Product[this.Count - 1];
            for (int i = 0, j = 0; i < this.Count; i++, j++)
            {
                // i is for the old array, j is for the new one
                if (this.List[i].GetID() == id)
                {
                    i++;
                    // Skip this item 
                }
                tmp[j] = this.List[i];
            }
            this.List = tmp;
            Console.WriteLine("The Element has been deleted!");
        }
        public void EditInfoProduct(string id, Product product)
        {

            Product tmp = this.List[this.Find(id)];

            int day = 0;
            int year = 0;
            int month = 0;
            int insuranceMonth = 0;
            int wattage = 0;
            string producer = "";

            if (tmp is Food)
            {
                Console.Write("Enter Producer: ");
                producer = Console.ReadLine();

                Console.WriteLine("Manufacture Date:");
                Console.Write("Enter Day: ");
                day = int.Parse(Console.ReadLine());
                Console.Write("Enter Month: ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Enter Year: ");
                year = int.Parse(Console.ReadLine());
                DateTime manufactureDate = new DateTime(year, month, day);

                Console.WriteLine("Expiration Date:");
                Console.Write("Enter Day: ");
                day = int.Parse(Console.ReadLine());
                Console.Write("Enter Month: ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Enter Year: ");
                year = int.Parse(Console.ReadLine());
                DateTime expirationDate = new DateTime(year, month, day);

                tmp = new Food(product.GetID(), product.GetName(), product.GetPrice(), product.GetAmount(), producer, manufactureDate, expirationDate);
            }
            else if (tmp is Ceramic)
            {
                Console.Write("Enter Producer: ");
                producer = Console.ReadLine();

                Console.WriteLine("Receive Date:");
                Console.Write("Enter Day: ");
                day = int.Parse(Console.ReadLine());
                Console.Write("Enter Month: ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Enter Year: ");
                year = int.Parse(Console.ReadLine());
                DateTime receiveDate = new DateTime(year, month, day);

                tmp = new Ceramic(product.GetID(), product.GetName(), product.GetPrice(), product.GetAmount(), producer, receiveDate);
            }
            else if (tmp is Electronic)
            {
                Console.Write("Enter Insurance Months: ");
                insuranceMonth = int.Parse(Console.ReadLine());
                Console.Write("Enter Product's Wattage: ");
                wattage = int.Parse(Console.ReadLine());
                tmp = new Electronic(product.GetID(), product.GetName(), product.GetPrice(), product.GetAmount(), insuranceMonth, wattage);
            }                            
        }

        public void SortListbyName()
        {
            Array.Sort(this.List, new Product.NameComparer());
        }

        public void SortListbyAmount()
        {       
            Array.Sort(this.List, new Product.AmountComparer());
        }

        // Constructors
        public ProductList(int maxLength)
        {
            this.MaxLength = maxLength > 0 ? maxLength : 0;
            this.List = new Product[this.MaxLength];
            this.Count = 0;
        }
    }
}
