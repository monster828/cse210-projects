using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Random random = new();
            int number = random.Next(1, 100);
            int guesses = 0;

            int guess = -1;
            while (number != guess)
            {
                Console.Write("What is your guess (1-100)?");
                guess = int.Parse(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }

                guesses++;
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guesses} guesses");
            Console.Write("Play again (yes/no)? ");
            playAgain = Console.ReadLine();   
        }        
    }
}