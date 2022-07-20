using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    public enum City
    {
        Non = 0,
        Moscow,
        SaintPetersburg,
        Ekaterinburg,
        Novgorod,
        Pskov,
        Sochi,
        Murmansk,
        Vologda,
        Samara,
        Saratov,
        Pensa
    }

    class Direction : IString
    {
        private City _from;
        private City _to;

        public Direction(City from, City to)
        {
            if (from == to)
            {
                _from = City.Non;
                _to = City.Non;
            }
            else
            {
                _from = from;
                _to = to;
            }
        }

        public override string ToString()
        {
            return _from.ToString() + " - " + _to.ToString();
        }
    }
}
