using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new();
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(number);
            }
        }

        float adverage = 0;
        int sum = 0;
        int largestNumber = 0;
        foreach (int num in numbers)
        {
            sum += num;

            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }

        adverage = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {adverage}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}