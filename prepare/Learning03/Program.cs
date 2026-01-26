using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction = new();
        Random random = new();

        for (int i = 0; i < 20; i++)
        {
            int top = random.Next();
            int bottom = random.Next();
            fraction.SetTop(top);
            fraction.SetBottom(bottom);

            Console.WriteLine($"Fraction {i}: string: {fraction.GetFractionString()}, Number: {fraction.GetDecimalValue()}");
        }
    }
}