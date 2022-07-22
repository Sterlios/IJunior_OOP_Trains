namespace Trains
{
    class Continuer : IString
    {
        private IDisplay _printer;
        private IStringInput _answerer;

        public Continuer(IDisplay printer, IStringInput answerer)
        {
            _printer = printer;
            _answerer = answerer;
        }

        public bool Request()
        {
            const string yesWord = "y";
            const string noWord = "n";

            _printer.Display(this);
            string command = _answerer.Get();

            if (command.ToLower() == yesWord)
            {
                return true;
            }
            else if (command.ToLower() == noWord)
            {
                return false;
            }
            else
            {
                return Request();
            }
        }

        public override string ToString()
        {
            return "Продолжаем? (Y/N) ";
        }
    }
}
