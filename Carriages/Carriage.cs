namespace Trains
{
    abstract class Carriage : IString
    {
        public int SeatsCount { get; private set; }

        public Carriage(int seatsCount)
        {
            SeatsCount = seatsCount;
        }

        public override string ToString()
        {
            return SeatsCount + " мест\n";
        }
    }
}
