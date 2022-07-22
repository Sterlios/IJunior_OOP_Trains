﻿using System;

namespace Trains
{
    class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Position(int x = -1, int y = -1)
        {
            X = x > -1 ? x : Console.CursorLeft;
            Y = y > -1 ? y : Console.CursorTop;

            SetCursorPosition();
        }

        public void SetCursorPosition()
        {
            Console.SetCursorPosition(X, Y);
        }

        public void SetNextLine()
        {
            Y++;
            SetCursorPosition();
        }

        public bool Equals(Position other)
        {
            return X == other.X && Y == other.Y;
        }
    }
}
