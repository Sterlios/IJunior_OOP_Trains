namespace Trains
{
    class DirectionCreator : ICreator
    {
        private INumberInput _dataInput;
        private IDisplay _display;

        public DirectionCreator(IDisplay display, INumberInput dataInput)
        {
            _display = display;
            _dataInput = dataInput;
        }

        public object Create()
        {
            City outCity = (City)_dataInput.Get();
            City inCity = (City)_dataInput.Get();

            if (outCity == inCity)
            {
                return Create();
            }

            Direction direction = new Direction(outCity, inCity);
            _display.Display(direction);

            return direction;
        }
    }
}
