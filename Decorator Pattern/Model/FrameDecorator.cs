using Decorator_Pattern;

namespace Decorator_Pattern.Model
{
    public class FrameDecorator : TextDecorator
    {
        public FrameDecorator(IText innerText) : base(innerText)
        {
        }

        public override void Display()
        {
            Console.Write("*** ");
            base.Display();
            Console.Write(" ***");
        }
    }
}
