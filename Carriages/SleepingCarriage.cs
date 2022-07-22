namespace Trains
{
    class SleepingCarriage : Carriage
    {
        public SleepingCarriage() : base(65) { }

        public override string ToString()
        {
            return "Плацкарт " + base.ToString();
        }
    }
}
