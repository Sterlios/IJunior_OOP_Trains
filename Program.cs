using System;

namespace Trains
{
    class Program
    {
        static void Main()
        {
            bool isContinue = true;
            ICreator directionCreator = new DirectionCreator(new ConsoleDirectionPrinter(), new RandomDirectionInput());
            ICreator ticketSeller = new TicketSeller(new ConsoleTicketsPrinter(), new RandomTicketsInput());
            TrainCreator trainCreator = new TrainCreator(new ConsoleTrainPrinter(), new RandomCarriageInput());

            while (isContinue)
            {
                Console.Clear();

                Direction direction = (Direction)directionCreator.Create();
                int tickets = (int)ticketSeller.Create();
                trainCreator.SetTickets(tickets);
                Train train = (Train)trainCreator.Create();

                Console.ReadKey();
            }
        }
    }
}
