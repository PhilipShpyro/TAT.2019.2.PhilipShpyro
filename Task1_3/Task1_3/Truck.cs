namespace Task1_3
{
    class Truck : Vehicle
    {
        public Truck(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {

        }
        public override string ToString()
        {
            return "truck\n" + base.ToString();
        }
    }
}
