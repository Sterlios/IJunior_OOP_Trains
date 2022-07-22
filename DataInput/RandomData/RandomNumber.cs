using System;

namespace Trains
{
    abstract class RandomNumber : INumberInput
    {
        private int _minRange;
        private int _maxRange;
        private static Random _random;

        public RandomNumber(int minRange, int maxRange)
        {
            _minRange = minRange;
            _maxRange = maxRange;
            _random = new Random();
        }

        public RandomNumber(int maxRange):this(1, maxRange) { }

        public int Get()
        {
            return _random.Next(_minRange, _maxRange);
        }
    }
}
