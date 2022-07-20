using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class RandomDirectionInput : RandomData
    {
        public RandomDirectionInput():base(Enum.GetNames(typeof(City)).Length) { }
    }
}
