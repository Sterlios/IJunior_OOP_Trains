using System;

namespace Trains
{
    class ConsoleTickets : IDisplay
    {
        public void Display(IString String)
        {
            Position position = new Position(30, 0);
            Console.WriteLine("Продано билетов:");
            position.SetNextLine();
            Console.WriteLine(String);
        }
    }
}
