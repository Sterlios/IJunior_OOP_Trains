using System;

namespace Trains
{
    class ConsoleCarriage : IDisplay
    {
        private Position _position;
        private Position _startPosition;

        public ConsoleCarriage()
        {
            int startPositionX = 50;
            int startPositionY = 5;
            _position = new Position(startPositionX, startPositionY);
            _startPosition = new Position(startPositionX, startPositionY);
        }

        public void Display(IString String)
        {
            DisplayTitle();
            _position.SetCursorPosition();
            Console.WriteLine(String);
            _position.SetNextLine();
        }

        private void DisplayTitle()
        {
            if (_startPosition.Equals(_position))
            {
                _position.SetCursorPosition();
                Console.WriteLine("Вагоны поезда: ");
                _position.SetNextLine();
            }
        }
    }
}
