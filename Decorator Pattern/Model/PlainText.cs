using Decorator_Pattern;

namespace Decorator_Pattern.Model
{
    public class PlainText : IText
    {
        private string _text;

        public PlainText(string text)
        {
            _text = text;
        }

        public void Display()
        {
            Console.Write(_text);
        }
    }
}
