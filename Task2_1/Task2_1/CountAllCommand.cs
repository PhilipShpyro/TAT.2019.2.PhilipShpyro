using System;

namespace Task2_1
{
    class CountAllCommand : ICommand
    {
        Car[] cars;

        public CountAllCommand(Car[] cars)
        {
            this.cars = cars;
        }
        public void Execute()
        {
            if (cars == null)
                return;
            Console.WriteLine("All = " + cars.Length);
        }
    }
}
