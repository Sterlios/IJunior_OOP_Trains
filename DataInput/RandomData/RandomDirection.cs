using System;

namespace Trains
{
    class RandomDirection : RandomNumber
    {
        public RandomDirection():base(Enum.GetNames(typeof(City)).Length) { }
    }
}
