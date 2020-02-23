using System;

namespace Task1_4
{
    class Drone : FlyableObject
    {
        private const double MaxSpeed = 30;

        public Drone() : base()
        {

        }
        public Drone(Point point) : base(point)
        {

        }

        private bool IsReaching(Point point)
        {
            double maxDistance = 1000000;
            return Point.Distance(point, CurrentPoint) < maxDistance;
        }
        public override void FlyTo(Point point)
        {
            if(!IsReaching(point))
            {
                Console.WriteLine("The distance is too long for the drone!");
                return;
            }
            base.FlyTo(point);
        }
        public override double GetFlyTime(Point point)
        {
            if (!IsReaching(point))
            {
                Console.WriteLine("The distance is too long for the drone!");
                return 0;
            }
            double timeStep = 10.0 / 60;
            double timeFroze = 1.0 / 60;

            double distance = Point.Distance(CurrentPoint, point) / 1000;
            double time = 0;
            Speed = new Random().NextDouble() * MaxSpeed;
            for(double passedDistance = 0; passedDistance < distance; passedDistance += Speed * timeStep)
            {
                if(passedDistance > distance)
                {
                    time -= (passedDistance - distance) / Speed;
                    break;
                }
                time += timeStep + timeFroze;
                Speed = new Random().NextDouble() * MaxSpeed;
            }
            return time;
        }
    }
}
