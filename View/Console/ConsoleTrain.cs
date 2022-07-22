using System;

namespace Trains
{
    class ConsoleTrain : IDisplay
    {
        public void Display(IString String)
        {
            Position position = new Position(50, 3);
            Console.WriteLine(String);
        }
    }
}
