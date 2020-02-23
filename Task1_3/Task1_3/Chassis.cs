namespace Task1_3
{
    class Chassis
    {
        private int wheelsAmount;
        private string number;
        private double load;
        public Chassis(int wheelsAmount, string number, double load)
        {
            this.wheelsAmount = wheelsAmount;
            this.number = number;
            this.load = load;
        }
        public override string ToString()
        {
            return "    chassis: " + wheelsAmount + " wheels, " + load + " kg load, number " + number;
        }
    }
}
