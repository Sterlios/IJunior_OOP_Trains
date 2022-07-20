using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class Train : IString
    {
        private List<Carriage> _carriages;
        int _seatsCount;

        public Train()
        {
            _carriages = new List<Carriage>();
            _seatsCount = 0;
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

        public int GetSeatsCount()
        {
            return _seatsCount;
        }

        public override string ToString()
        {
            string text = "\n";
            int index = 0;

            foreach(Carriage carriage in _carriages)
            {
                index++;
                text += index + " " + carriage.ToString() + " " + carriage.SeatsCount + " мест\n";
            }

            text += "ИТОГО: " + _seatsCount + " мест";

            return text;
        }
    }
}
