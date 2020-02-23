namespace Task1_3
{
    class Car : Vehicle
    {
        public Car(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {

        }
        public override string ToString()
        {
            return "car\n" + base.ToString();
        }
    }
}
