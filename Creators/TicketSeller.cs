using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    class TicketSeller : ICreator
    {
        private IDataInput _dataInput;
        private IPrinter _display;

        public TicketSeller(IPrinter display, IDataInput dataInput)
        {
            _display = display;
            _dataInput = dataInput;
        }

        public object Create()
        {
            Tickets tickets = new Tickets(_dataInput.GetNumber());
            _display.Print(tickets);

            return tickets.Count;
        }
    }
}
