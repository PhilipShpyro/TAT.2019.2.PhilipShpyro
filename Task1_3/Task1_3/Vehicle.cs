namespace Task1_3
{
    abstract class Vehicle
    {
        private Engine engine;
        private Transmission transmission;
        private Chassis chassis;

        public Vehicle(Engine engine, Transmission transmission, Chassis chassis)
        {
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
        }

        public override string ToString()
        {
            return engine + "\n" + transmission + "\n" + chassis;
        }
    }
}
