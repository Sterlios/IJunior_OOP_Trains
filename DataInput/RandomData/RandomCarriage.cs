using System;

namespace Trains
{
    class RandomCarriage : RandomNumber
    {
        public RandomCarriage() : base(Enum.GetNames(typeof(CarriageType)).Length + 1) { }
    }
}
