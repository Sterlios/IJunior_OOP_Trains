using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    abstract class RandomData : IDataInput
    {
        private int _minRange;
        private int _maxRange;
        private static Random _random;

        public RandomData(int maxRange, int minRange = 1)
        {
            _minRange = minRange;
            _maxRange = maxRange;
            _random = new Random();
        }

        public int GetNumber()
        {
            return _random.Next(_minRange, _maxRange);
        }
    }
}
