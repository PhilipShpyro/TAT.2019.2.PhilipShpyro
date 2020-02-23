using System;

namespace Task2_1
{
    class AveragePriceTypeCommand : ICommand
    {
        Car[] cars;
        string type;

        public AveragePriceTypeCommand(Car[] cars, string type)
        {
            this.cars = cars;
            this.type = type;
        }
        public void Execute()
        {
            if (cars == null)
                return;
            double totalPriceType = 0;
            int carsTypeAmount = 0;
            foreach(Car car in cars)
            {
                if(car.Type == type)
                {
                    carsTypeAmount++;
                    totalPriceType += car.Price;
                }
            }
            if (carsTypeAmount == 0)
                return;
            Console.WriteLine("Average price of type = " + string.Format("{0:N3}", totalPriceType / carsTypeAmount));
        }
    }
}
