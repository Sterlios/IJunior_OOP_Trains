namespace Trains
{
    class TicketSeller : ICreator, IString
    {
        private INumberInput _dataInput;
        private IDisplay _display;
        private int _tickets;

        public TicketSeller(IDisplay display, INumberInput dataInput)
        {
            _tickets = 0;
            _display = display;
            _dataInput = dataInput;
        }

        public object Create()
        {
            _tickets = _dataInput.Get();
            _display.Display(this);

            return _tickets;
        }

        public override string ToString()
        {
            return _tickets.ToString();
        }
    }
}
