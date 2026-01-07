using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float grade = float.Parse(userInput);

        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }else if (grade >= 80)
        {
            letter = "B";
        }else if (grade >= 70)
        {
            letter = "C";
        }else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        if (grade / 10 >= 7 && grade >= 60 && grade < 90)
        {
            sign = "+";
        }else if (grade / 10 < 3 && grade >= 60)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade: {letter}{sign}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You failed, maybe next time.");
        }
    }
}