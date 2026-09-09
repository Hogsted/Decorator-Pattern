using Decorator_Pattern;

namespace Decorator_Pattern.Model
{
    public class ColorDecorator : TextDecorator
    {
        private ConsoleColor _color;

        public ColorDecorator(IText innerText, ConsoleColor color) : base(innerText)
        {
            _color = color;
        }

        public override void Display()
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = _color;

            base.Display();

            Console.ForegroundColor = originalColor;
        }
    }
}
