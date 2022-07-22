using System;

namespace Trains
{
    class ConsoleContinuer : IDisplay
    {
        public void Display(IString String)
        {
            _ = new Position(130, 0);
            Console.WriteLine(String);
        }
    }
}
