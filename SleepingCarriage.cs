using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class SleepingCarriage : Carriage
    {
        public SleepingCarriage() : base(65) { }

        public override string ToString()
        {
            return "Плацкарт";
        }
    }
}
