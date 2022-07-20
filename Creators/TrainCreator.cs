using System;
using System.Collections.Generic;
using System.Text;

namespace Trains
{
    enum CarriageType
    {
        CoupeCarriage = 1,
        SleepingCarriage,
        ElectricCarriage
    }

    class TrainCreator : ICreator
    {
        private IPrinter _display;
        private int _ticketsCount;
        private IDataInput _dataInput;

        public TrainCreator(IPrinter display, IDataInput dataInput)
        {
            _ticketsCount = 0;
            _display = display;
            _dataInput = dataInput;
        }

        public object Create()
        {
            Train train = null; 

            if (_ticketsCount > 0)
            {
                train = new Train();

                int freeTickets = _ticketsCount;

                while(freeTickets > 0)
                {
                    Carriage carriage = CreateCarriage();

                    if (train.TryAddCarriage(carriage))
                    {
                        freeTickets -= carriage.SeatsCount;
                    }
                }

                _display.Print(train);
            }

            return train;
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
                _display.Print(errorMessage);
            }
        }

        private Carriage CreateCarriage()
        {
            CarriageType carriageType = (CarriageType)_dataInput.GetNumber();

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
