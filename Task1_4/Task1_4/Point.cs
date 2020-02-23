using System;
namespace Task1_4
{
    /// <summary>
    /// The distance is in meters
    /// </summary>
    struct Point
    {
        private double x;
        private double y;
        private double z;

        public Point(double x, double y, double z)
        {
            if (x < 0 || y < 0 || z < 0)
                throw new Exception("Point parameter is greater than or equal to zero");
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static double Distance(Point point1, Point point2)
        {
            return Math.Sqrt
                (
                (point1.x - point2.x) * (point1.x - point2.x) +
                (point1.y - point2.y) * (point1.y - point2.y) +
                (point1.z - point2.z) * (point1.z - point2.z)
                );
        }
    }
}
