using Decorator_Pattern;

namespace Decorator_Pattern.Model
{
    public abstract class TextDecorator : IText
    {
        protected IText _innerText;

        protected TextDecorator(IText innerText)
        {
            _innerText = innerText;
        }

        public virtual void Display()
        {
            _innerText.Display();
        }
    }
}
