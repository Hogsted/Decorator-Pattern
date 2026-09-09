using Decorator_Pattern;

namespace Decorator_Pattern.Model
{
    public class BlinkingDecorator : TextDecorator
    {
        public BlinkingDecorator(IText innerText) : base(innerText)
        {
        }

        public override void Display()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\r" + new string(' ', 60) + "\r");
                if (i % 2 == 0)
                {
                    base.Display();
                }
                Thread.Sleep(300);
            }

            Console.Write("\r" + new string(' ', 60) + "\r");
            base.Display();
        }
    }
}
