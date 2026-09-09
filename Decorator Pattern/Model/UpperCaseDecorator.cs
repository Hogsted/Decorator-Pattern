using Decorator_Pattern;

namespace Decorator_Pattern.Model
{
    public class UpperCaseDecorator : TextDecorator
    {
        public UpperCaseDecorator(IText innerText) : base(innerText)
        {
        }

        public override void Display()
        {
            // Fanger det den indpakkede tekst ville skrive, så vi kan lave om til store bogstaver
            var originalOut = Console.Out;
            var capturedText = new StringWriter();
            Console.SetOut(capturedText);

            base.Display();

            Console.SetOut(originalOut);
            Console.Write(capturedText.ToString().ToUpper());
        }
    }
}
