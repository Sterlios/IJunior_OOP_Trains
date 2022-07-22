using System;

namespace Trains
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(200,50);

            bool isContinue = true;
            DirectionCreator directionCreator = new DirectionCreator(new ConsoleDirection(), new RandomDirection());
            TicketSeller ticketSeller = new TicketSeller(new ConsoleTickets(), new RandomTickets());
            TrainCreator trainCreator = new TrainCreator(new ConsoleTrainCreator(), new RandomCarriage());
            Continuer continuer = new Continuer(new ConsoleContinuer(), new ConsoleAnswerer());

            while (isContinue)
            {
                Console.Clear();

                Direction direction = (Direction)directionCreator.Create();
                int tickets = (int)ticketSeller.Create();
                trainCreator.SetDefaultDisplaies(new ConsoleTrain(), new ConsoleCarriage());
                trainCreator.SetDirection(direction);
                trainCreator.SetTickets(tickets);
                Train train = (Train)trainCreator.Create();
                Driver driver = new Driver(new ConsoleDriver(), train);
                isContinue = continuer.Request();
            }
        }
    }
}
