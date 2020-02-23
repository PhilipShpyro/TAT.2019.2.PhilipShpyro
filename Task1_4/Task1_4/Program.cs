using System;

namespace Task1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyableObject drone = new Drone();
            Console.WriteLine(drone.GetFlyTime(new Point(10000, 1000, 1000)));
        }
    }
}
