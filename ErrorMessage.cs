namespace Trains
{
    class ErrorMessage : IString
    {
        private string _text;

        public ErrorMessage(string text)
        {
            _text = text;
        } 

        public override string ToString()
        {
            return _text;
        }
    }
}
