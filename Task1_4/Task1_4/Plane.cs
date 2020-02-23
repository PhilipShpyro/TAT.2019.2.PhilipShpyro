namespace Task1_4
{
    class Plane : FlyableObject
    {
        public Plane() : base()
        {
            Speed = 200;
        }
        public Plane(Point point) : base(point)
        {
            Speed = 200;
        }

        public override double GetFlyTime(Point point)
        {
            double upSpeed = 10;
            double step = 10000;

            double distance = Point.Distance(CurrentPoint, point);
            double time = 0;
            for(double i = 0; i < distance - step; i += step)
            {
                time += step / (Speed * 1000);
                Speed += upSpeed;
            }
            time += (distance % step) / (Speed * 1000);
            Speed = 200;
            return time;
        }
    }
}
