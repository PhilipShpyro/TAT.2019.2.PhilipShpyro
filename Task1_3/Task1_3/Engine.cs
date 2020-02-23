namespace Task1_3
{
    class Engine
    {
        private int power;
        private double volume;
        private string type;
        private string serialNumber;
        public Engine(int power, double volume, string type, string serialNumber)
        {
            this.power = power;
            this.volume = volume;
            this.type = type;
            this.serialNumber = serialNumber;
        }
        public override string ToString()
        {
            return "    engine: volume " + volume + "l, type " + type + ", power " + power + " bhp, serial number " + serialNumber;
        }
    }
}
