using System;

namespace Trains
{
    class ConsoleTrainCreator : IDisplay
    {
        public void Display(IString String)
        {
            Position position = new Position(50, 0);
            Console.WriteLine("Составлен поезд: ");
            position.SetNextLine();
            Console.WriteLine(String);
        }
    }
}
