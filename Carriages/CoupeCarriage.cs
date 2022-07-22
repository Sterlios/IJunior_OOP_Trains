namespace Trains
{
    class CoupeCarriage : Carriage
    {
        public CoupeCarriage() : base(40) { }

        public override string ToString()
        {
            return "Купе " + base.ToString();
        }
    }
}
