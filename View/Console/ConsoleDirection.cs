using System;

namespace Trains
{
    class ConsoleDirection : IDisplay
    {
        public void Display(IString String)
        {
            Position position = new Position(0, 0);
            Console.WriteLine("Сформировано направление: \n");
            position.SetNextLine();
            Console.WriteLine(String);
        }
    }
}
