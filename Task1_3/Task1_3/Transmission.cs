namespace Task1_3
{
    class Transmission
    {
        private string type;
        private int gearsAmount;
        private string developer;
        public Transmission(int gearsAmount, string type, string developer)
        {
            this.gearsAmount = gearsAmount;
            this.type = type;
            this.developer = developer;
        }
        public override string ToString()
        {
            return "    transmission: gears amount " + gearsAmount + ", type " + type + ", developer " + developer;
        }
    }
}
