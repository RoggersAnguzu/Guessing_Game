using System;
namespace Game
{
    public class Gam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Competition!\n");
            Answer();
        }
        static void Answer()
        {
            Console.WriteLine("The Number are between 1 and 50. Can you guess them?\n1. Yes\n2. No");
            Console.Write("Choose your opinion  from the above options before we continue!: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            switch(answer)
            {
                case 1:
                    Console.WriteLine("You are eligible");
                    Choice();
                    break;
                case 2:
                    Console.WriteLine("That is negativity!");
                    Console.WriteLine("Go tell your entire family that you are cowards");
                    break;
                default:
                    Console.WriteLine("This is a Wrong Attempt!");
                    break;
            }
        }
        static void Choice()
        {
            Random GenNumber = new Random();
            int GuessNumber = GenNumber.Next(1, 50);

            for (int i = 1; i<4;)
            {
                Console.WriteLine("Now Enter your Number choice to check on your Genius IQ level!:\n");
                int Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess==GuessNumber)
                {
                    Console.Write("Congratulations! You win");
                }
               else
                {
                    Console.WriteLine("Wrong! You have Failed\n");
                    Console.WriteLine("You have been given another attempt! Please Try");
                    Console.WriteLine($"You are remaining with {4-i} chances");
                    i++;
                }
            }
        }

    }
}
