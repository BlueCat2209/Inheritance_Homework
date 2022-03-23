using System;

namespace _5._Electric_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            VNCustomer[] vnCustomers = new VNCustomer[3];
            vnCustomers[0] = new VNCustomer("1", "Thuan", new DateTime(1, 1, 1), 100, 200, 1, "Business");
            vnCustomers[1] = new VNCustomer("2", "Thanh", new DateTime(1, 1, 1), 50, 200, 1, "Household");
            vnCustomers[2] = new VNCustomer("3", "Khanh", new DateTime(1, 1, 1), 500, 400, 2, "Manufacture");
            FRcustomer[] frCustomers = new FRcustomer[3];
            frCustomers[0] = new FRcustomer("1", "Tony", new DateTime(1, 1, 1), "Germany", 100, 1);
            frCustomers[1] = new FRcustomer("2", "Timy", new DateTime(1, 1, 1), "Russia", 150, 1);
            frCustomers[2] = new FRcustomer("3", "Lily", new DateTime(1, 1, 1), "America", 50, 1);

            int TotalElectricityVN = 0;
            foreach (VNCustomer customer in vnCustomers)
            {
                TotalElectricityVN += customer.GetElectricityUsed();
            }
            int TotalElectricityFR = 0;
            foreach (FRcustomer customer in frCustomers)
            {
                TotalElectricityFR += customer.GetElectricityUsed();
            }
            Console.WriteLine($"The total electricity has been used by Vietnam customers is: {TotalElectricityVN}");
            Console.WriteLine($"The total electricity has been used by Foreign customers is: {TotalElectricityFR}");

            double averageBill = 0;
            foreach (FRcustomer customer in frCustomers)
            {
                averageBill += customer.GetTotal();
            }
            averageBill /= 3;
            Console.WriteLine($"The average bill of Foreign customers is: {averageBill}");

            Console.Write($"This is name of customer in 1/1/1: ");
            foreach (VNCustomer customer in vnCustomers)
            {
                Console.Write($"{customer.GetName()}, ");
            }
            foreach (FRcustomer customer in frCustomers)
            {
                Console.Write($"{customer.GetName()}, ");
            }
        }
    }
}