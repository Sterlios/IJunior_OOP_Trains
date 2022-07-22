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
            const string YesWord = "y";
            const string NoWord = "n";

            _printer.Display(this);
            string command = _answerer.Get();

            if (command.ToLower() == YesWord)
            {
                return true;
            }
            else if (command.ToLower() == NoWord)
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
