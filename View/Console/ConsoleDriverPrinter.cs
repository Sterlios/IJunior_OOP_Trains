using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class ConsoleDriverPrinter : IPrinter
    {
        public void Print(IString String)
        {
            Console.WriteLine("Поезд " + String.ToString() + " отправлен");
        }
    }
}
