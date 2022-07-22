using System.Collections.Generic;

namespace Trains
{
    class Train : IString
    {
        private List<Carriage> _carriages;
        private int _seatsCount;
        private IDisplay _display;
        private IDisplay _carriageDisplay;

        public Direction Direction { get; private set; }

        public Train(Direction direction, IDisplay display, IDisplay carriageDisplay)
        {
            _carriages = new List<Carriage>();
            _seatsCount = 0;
            Direction = direction;
            _display = display;
            _carriageDisplay = carriageDisplay;
        }

        public bool TryAddCarriage(Carriage carriage)
        {
            if (_carriages.Contains(carriage) == false)
            {
                _carriages.Add(carriage);
                _seatsCount += carriage.SeatsCount;
                return true;
            }

            return false;
        }

        public void Display()
        {
            _display.Display(this);

            foreach(Carriage carriage in _carriages)
            {
                _carriageDisplay.Display(carriage);
            }
        }

        public override string ToString()
        {
            return "Общее количество мест: " + _seatsCount;
        }
    }
}
