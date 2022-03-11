using System;

namespace _1._Travel_Bus
{
    class Program
    {
        static void GetAllRevenue(InTownBus bus1, InTownBus bus2, OutTownBus bus3, OutTownBus bus4)
        {
            Console.WriteLine($"The revenue of all buses is: {bus1.GetRevenue() + bus2.GetRevenue() + bus3.GetRevenue() + bus4.GetRevenue()}");
        }
        static void GetTypesRevenue(InTownBus bus1, InTownBus bus2, OutTownBus bus3, OutTownBus bus4)
        {
            Console.WriteLine($"The revenue of buses in town is: {bus1.GetRevenue() + bus2.GetRevenue()}");
            Console.WriteLine($"The revenue of buses out town is: {bus3.GetRevenue() + bus4.GetRevenue()}");
        }
        static void Main(string[] args)
        {
            InTownBus bus1 = new InTownBus(1, "a", "50a", 10, 10, 100);
            InTownBus bus2 = new InTownBus(2, "b", "50b", 20, 20, 200);
            OutTownBus bus3 = new OutTownBus(3, "c", "50c", "hcm", 1, 300);
            OutTownBus bus4 = new OutTownBus(4, "d", "50d", "ntp", 2, 400);

            GetAllRevenue(bus1,bus2,bus3,bus4);
            GetTypesRevenue(bus1,bus2,bus3,bus4);
        }
    }
}
