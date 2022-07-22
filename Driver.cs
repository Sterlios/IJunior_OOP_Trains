namespace Trains
{
    class Driver
    {
        public Driver(IDisplay display, Train train)
        {
            display.Display(train.Direction);
        }
    }
}
