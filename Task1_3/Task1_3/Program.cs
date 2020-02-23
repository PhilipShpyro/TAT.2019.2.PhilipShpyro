using System;

namespace Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car
                (
                new Engine(220, 3.0, "V6", "5bd22a"),
                new Transmission(6, "manual", "BMW"),
                new Chassis(4, "5bd22", 7000)
                );
            Console.WriteLine(car);

            Vehicle bus = new Bus
                (
                new Engine(450, 6.0, "W6", "4bddWa"),
                new Transmission(5, "automatical", "IVECO"),
                new Chassis(12, "4bddWa", 40000)
                );
            Console.WriteLine(bus);

            Vehicle scooter = new Scooter
                (
                new Engine(64, 1.0, "V2", "Vdf421"),
                new Transmission(3, "automatical", "Mitsubishi"),
                new Chassis(0, "Vdf421", 500)
                );
            Console.WriteLine(scooter);

            Vehicle truck = new Truck
                (
                new Engine(800, 7.0, "V8", "Vd2111"),
                new Transmission(12, "manual", "ClutchMasters"),
                new Chassis(8, "Vd2111", 150000)
                );
            Console.WriteLine(truck);
        }
    }
}
