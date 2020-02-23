using System;

namespace Task2_1
{
    class AveragePriceCommand : ICommand
    {
        Car[] cars;

        public AveragePriceCommand(Car[] cars)
        {
            this.cars = cars;
        }
        public void Execute()
        {
            if (cars == null)
                return;
            double totalPrice = 0;
            foreach(Car car in cars)
            {
                totalPrice += car.Price;
            }
            Console.WriteLine("Average price = " + string.Format("{0:N3}", (totalPrice / cars.Length)));
        }
    }
}
