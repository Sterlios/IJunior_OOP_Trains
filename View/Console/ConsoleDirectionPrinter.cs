using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class ConsoleDirectionPrinter : IPrinter
    {
        public void Print(IString String)
        {
            Console.WriteLine("Направление: " + String.ToString());
        }
    }
}
