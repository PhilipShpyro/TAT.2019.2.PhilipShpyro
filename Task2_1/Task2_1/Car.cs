using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1
{
    class Car
    {
        public string Type { get; }
        public string Model { get; }
        public double Price { get; }

        public Car(string type, string model, double price)
        {
            Type = type;
            Model = model;
            Price = price;
        }
    }
}
