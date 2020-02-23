namespace Task1_3
{
    class Scooter : Vehicle
    {
        public Scooter(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {

        }
        public override string ToString()
        {
            return "scooter\n" + base.ToString();
        }
    }
}
