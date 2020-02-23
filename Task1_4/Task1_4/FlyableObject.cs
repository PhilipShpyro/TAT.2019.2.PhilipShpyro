namespace Task1_4
{
    /// <summary>
    /// The distacne is in meters, the speed is in km/h
    /// </summary>
    abstract class FlyableObject : IFlyable
    {
        protected Point CurrentPoint { get; set; }
        protected double Speed { get; set; }

        public FlyableObject()
        {
            CurrentPoint = new Point(0, 0, 0);
        }
        public FlyableObject(Point point)
        {
            CurrentPoint = point;
        }

        public virtual void FlyTo(Point point)
        {
            CurrentPoint = point;
        }
        public abstract double GetFlyTime(Point point);
    }
}
