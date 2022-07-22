using System;

namespace Trains
{
    class ConsoleDriver : IDisplay
    {
        public void Display(IString String)
        {
            Position position = new Position(90, 0);
            Console.WriteLine("Поезд отправлен по направлению:");
            position.SetNextLine();
            Console.WriteLine(String);
        }
    }
}
