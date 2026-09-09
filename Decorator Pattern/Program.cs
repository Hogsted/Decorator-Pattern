using Decorator_Pattern;
using Decorator_Pattern.Model;

IText plain = new PlainText("Hej, verden!");
Console.Write("Almindelig tekst:      ");
plain.Display();
Console.WriteLine();

IText upperCase = new UpperCaseDecorator(new PlainText("Hej, verden!"));
Console.Write("Store bogstaver:       ");
upperCase.Display();
Console.WriteLine();

IText colored = new ColorDecorator(new PlainText("Hej, verden!"), ConsoleColor.Green);
Console.Write("Farvet tekst:          ");
colored.Display();
Console.WriteLine();

IText framed = new FrameDecorator(new PlainText("Hej, verden!"));
Console.Write("Tekst i ramme:         ");
framed.Display();
Console.WriteLine();

// Flere dekoratorer kombineret: ramme om farvet tekst med store bogstaver
IText combined = new FrameDecorator(
    new ColorDecorator(
        new UpperCaseDecorator(
            new PlainText("Hej, verden!")),
        ConsoleColor.Cyan));

Console.Write("Kombineret:            ");
combined.Display();
Console.WriteLine();

IText blinking = new BlinkingDecorator(new PlainText("Pas paa!"));
Console.Write("Blinkende (se konsol): ");
blinking.Display();
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Tryk en tast for at afslutte...");
Console.ReadKey();
