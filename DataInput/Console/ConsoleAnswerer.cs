using System;

namespace Trains
{
    class ConsoleAnswerer : IStringInput
    {
        private string _answer;
        private Position _position;

        public ConsoleAnswerer()
        {
            _answer = "";
            _position = new Position(130, 1);
        }

        public string Get()
        {
            ClearText();
            
            _position.SetCursorPosition();
            _answer = Console.ReadLine();

            return _answer;
        }

        private void ClearText()
        {
            _position.SetCursorPosition();

            for (int i = 0; i < _answer.Length; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
