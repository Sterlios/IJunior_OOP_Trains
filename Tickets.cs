using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class Tickets : IString
    {
        public int Count { get; private set; }

        public Tickets(int count)
        {
            Count = count;
        }

        public override string ToString()
        {
            return Count.ToString();
        }
    }
}
