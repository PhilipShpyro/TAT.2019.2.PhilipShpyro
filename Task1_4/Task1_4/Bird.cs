using System;

namespace Task1_4
{
    class Bird : FlyableObject
    {
        public Bird() : base()
        {
            Speed = new Random().NextDouble() * 20;
        }
        public Bird(Point point) : base(point)
        {
            Speed = new Random().NextDouble() * 20;
        }



        public override double GetFlyTime(Point point)
        {
            return Point.Distance(CurrentPoint, point) / (Speed * 1000);
        }
    }
}
