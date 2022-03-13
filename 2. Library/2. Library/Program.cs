using System;

namespace _2._Library
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBook[] textBooks = new TextBook[3];
            textBooks[0] = new TextBook("Toan", new DateTime(1, 1, 1), 10, 2, "tony", true);
            textBooks[1] = new TextBook("Ly", new DateTime(1, 1, 1), 5, 6, "tony", true);
            textBooks[2] = new TextBook("Anh", new DateTime(1, 1, 1), 20, 1, "tony", false);

            ReferenceBook[] referenceBooks = new ReferenceBook[3];
            referenceBooks[0] = new ReferenceBook("Nau an", new DateTime(1, 1, 1), 10, 2, "tony", 5);
            referenceBooks[1] = new ReferenceBook("Boi loi", new DateTime(1, 1, 1), 15, 1, "tony", 10);
            referenceBooks[2] = new ReferenceBook("Nhay cao", new DateTime(1, 1, 1), 5, 2, "tony", 0);

            double textBooksPrice = 0;
            foreach (TextBook book in textBooks)
            {
                textBooksPrice += book.GetTotalPrice();
            }
            Console.WriteLine($"The total price of Text books is {textBooksPrice}");

            double referenceBooksPrice = 0;
            foreach (ReferenceBook book in referenceBooks)
            {
                referenceBooksPrice += book.GetTotalPrice();
            }
            Console.WriteLine($"The total price of Reference books is {referenceBooksPrice}");


            double averagePrice = 0;
            foreach (ReferenceBook book in referenceBooks)
            {
                averagePrice += book.GetPrice();
            }
            averagePrice /= 3;
            Console.WriteLine($"The average price of the reference books is {averagePrice}");

            Console.Write("Enter the name of your publisher: ");
            string input = Console.ReadLine();

            Console.Write($"This is IDs of the books from the {input}'s publisher: ");
            foreach (TextBook book in textBooks)
            {
                if (book.GetPublisher() == input)
                {
                    Console.Write($"{book.GetID()}, ");
                }
            }
            foreach (ReferenceBook book in referenceBooks)
            {
                if (book.GetPublisher() == input)
                {
                    Console.Write($"{book.GetID()}, ");
                }
            }
        }
    }
}
