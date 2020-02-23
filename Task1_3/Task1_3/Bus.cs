namespace Task1_3
{
    class Bus : Vehicle
    {
        public Bus(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {

        }
        public override string ToString()
        {
            return "bus\n" + base.ToString();
        }
    }
}
