using System;

namespace Task2_1
{
    class CountTypesCommand : ICommand
    {
        Car[] cars;

        public CountTypesCommand(Car[] cars)
        {
            this.cars = cars;
        }
        public void Execute()
        {
            if (cars == null)
                return;
            int typesAmount = 0;
            for(int i = 0; i < cars.Length; i++)
            {
                bool match = false;
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if (cars[i].Type == cars[j].Type)
                    {
                        match = true;
                        break;
                    }
                }
                typesAmount = match ? typesAmount : typesAmount + 1;
            }
            Console.WriteLine("Types amount = " + typesAmount);
        }
    }
}
