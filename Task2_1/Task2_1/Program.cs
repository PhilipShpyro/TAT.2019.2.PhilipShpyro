using System;
using System.Collections.Generic;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Console.WriteLine("Enter the cars with info");
            while (true)
            {
                Console.WriteLine("Enter the type");
                string type = Console.ReadLine();
                Console.WriteLine("Enter the model");
                string model = Console.ReadLine();
                Console.WriteLine("Enter amount");
                uint amount = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Enter the price");
                double price = Convert.ToDouble(Console.ReadLine());
                for(uint i = 0; i < amount; i++)
                {
                    cars.Add(new Car(type, model, price));
                }
                Console.WriteLine("Enter more? (y/n)");
                if (Console.ReadLine()[0] != 'y')
                    break;
            }
            Invoker invoker = Invoker.Log();
            Console.WriteLine("Enter the command (count types, count all, average price, average price type, exit)");
            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "count types":
                        invoker.Command = new CountTypesCommand(cars.ToArray());
                        break;
                    case "count all":
                        invoker.Command = new CountAllCommand(cars.ToArray());
                        break;
                    case "average price":
                        invoker.Command = new AveragePriceCommand(cars.ToArray());
                        break;
                    case "average price type":
                        Console.WriteLine("Enter the type");
                        invoker.Command = new AveragePriceTypeCommand(cars.ToArray(), Console.ReadLine());
                        break;
                    case "exit":
                        return;
                    default:
                        continue;
                }
                invoker.StartCommand();
            }
        }
    }
}
