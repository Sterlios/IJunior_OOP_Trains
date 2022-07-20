using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class ConsoleTicketsPrinter : IPrinter
    {
        public void Print(IString String)
        {
            Console.WriteLine("Продано билетов: " + String.ToString());
        }
    }
}
