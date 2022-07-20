using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class RandomCarriageInput : RandomData
    {
        public RandomCarriageInput() : base(Enum.GetNames(typeof(CarriageType)).Length + 1) { }
    }
}
