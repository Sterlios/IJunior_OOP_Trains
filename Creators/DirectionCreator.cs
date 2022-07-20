using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class DirectionCreator : ICreator
    {
        private IDataInput _dataInput;
        private IPrinter _display;

        public DirectionCreator(IPrinter display, IDataInput dataInput)
        {
            _display = display;
            _dataInput = dataInput;
        }

        public object Create()
        {
            City outCity = (City)_dataInput.GetNumber();
            City inCity = (City)_dataInput.GetNumber();

            if (outCity == inCity)
            {
                return Create();
            }

            Direction direction = new Direction(outCity, inCity);
            _display.Print(direction);

            return direction;
        }
    }
}
