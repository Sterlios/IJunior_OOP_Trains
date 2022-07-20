using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    abstract class Carriage
    {
        public int SeatsCount { get; private set; }

        public Carriage(int seatsCount)
        {
            SeatsCount = seatsCount;
        }
    }
}
