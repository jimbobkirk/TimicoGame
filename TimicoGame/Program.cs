using System;
using System.Linq;
using TimicoGame.Objects;

namespace TimicoGameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to {World.WorldName}");
            while (true)
            {
                var input = Console.ReadLine();
                Console.WriteLine();

                if (input == "ViewShops")
                {
                    Console.WriteLine($"------ Shops of {World.WorldName} ------");
                    World.GetWorldStores().ForEach(store =>
                    {
                        Console.WriteLine(store.GetName());
                    });
                }
                else if (input.StartsWith("OpenShop"))
                {
                    var storeName = input.Split(" ", 2)[1];
                    var store = World.GetWorldStores().Where(s => s.GetName() == storeName).FirstOrDefault();

                    store.GetStock().ForEach(stock =>
                    {
                        Console.WriteLine($"Name: {stock.GetName()} Amount: {stock.GetAmount()} Value: {stock.GetValue()}");
                    });
                }

                Console.WriteLine();
            }
        }
    }
}
