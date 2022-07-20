using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class ConsoleTrainPrinter : IPrinter
    {
        public void Print(IString String)
        {
            Console.WriteLine("Составлен поезд: " + String.ToString());
        }
    }
}
