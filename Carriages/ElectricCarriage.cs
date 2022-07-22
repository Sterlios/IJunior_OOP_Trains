namespace Trains
{
    class ElectricCarriage : Carriage
    {
        public ElectricCarriage() : base(90) { }

        public override string ToString()
        {
            return "Электричка " + base.ToString();
        }
    }
}
