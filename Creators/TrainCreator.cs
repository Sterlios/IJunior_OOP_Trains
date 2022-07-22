namespace Trains
{
    enum CarriageType
    {
        CoupeCarriage = 1,
        SleepingCarriage,
        ElectricCarriage
    }

    class TrainCreator : ICreator, IString
    {
        private IDisplay _display;
        private IDisplay _carriageDisplay;
        private IDisplay _trainDisplay;
        private int _ticketsCount;
        private INumberInput _dataInput;
        private Direction _direction;

        public TrainCreator(IDisplay display, INumberInput dataInput)
        {
            _ticketsCount = 0;
            _display = display;
            _dataInput = dataInput;
        }

        public void SetDefaultDisplaies(IDisplay trainDisplay, IDisplay carriageDisplay)
        {
            _trainDisplay = trainDisplay;
            _carriageDisplay = carriageDisplay;
        }

        public object Create()
        {
            Train train = null; 

            if (_ticketsCount > 0)
            {
                train = CreateTrain();
                _display.Display(this);
                train.Display();
            }

            return train;
        }

        public void SetDirection(Direction direction)
        {
            _direction = direction;
        }

        public void SetTickets(int count)
        {
            if (count > 0)
            {
                _ticketsCount = count;
            }
            else
            {
                ErrorMessage errorMessage = new ErrorMessage("Неверное количество билетов");
                _display.Display(errorMessage);
            }
        }

        public override string ToString()
        {
            return _direction.ToString();
        }

        private Train CreateTrain()
        {
            Train train = new Train(_direction, _trainDisplay, _carriageDisplay);

            int freeTickets = _ticketsCount;

            while (freeTickets > 0)
            {
                Carriage carriage = CreateCarriage();

                if (train.TryAddCarriage(carriage))
                {
                    freeTickets -= carriage.SeatsCount;
                }
            }

            return train;
        }

        private Carriage CreateCarriage()
        {
            CarriageType carriageType = (CarriageType)_dataInput.Get();

            switch (carriageType)
            {
                case CarriageType.CoupeCarriage:
                    return new CoupeCarriage();
                case CarriageType.ElectricCarriage:
                    return new ElectricCarriage();
                case CarriageType.SleepingCarriage:
                    return new SleepingCarriage();
                default:
                    return null;
            }
        }
    }
}
