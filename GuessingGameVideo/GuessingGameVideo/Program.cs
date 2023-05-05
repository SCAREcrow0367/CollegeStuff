using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameVideo
{
    class Program
    {
        static int guess;
        static int answer;
        static int counter = 0;

        static void Main(string[] args)
        {
            Console.Title = "Guessing game C# Console";

            introduction();
            randomize();
            while (true)
            {
                askData();
                display();
                if (guess == answer)
                    break;
            }
            goodBye();
        }
        static void goodBye()
        {
            Console.WriteLine("thank you for using this Application");
            Console.WriteLine("Press any key to end.");
            Console.ReadLine();

        }
        static void introduction()
        {
            Console.WriteLine("Welcome to the guessing game C# console\nEnter any key to continue!");
            Console.ReadLine();

        }
        static void askData()
        {
            Console.Clear();
            counter++;
            while (true)
            {
                Console.WriteLine("Please enter integer between 0-20");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < 0 || guess > 20)
                    Console.WriteLine("Invalid expression, please try a within proper range.");
                else
                    break;
            }
        }
        static void randomize()
        {
            Random random = new Random();
            answer = random.Next(0, 20);
        }
        static void display()
        {
            if (guess == answer)
            {
                Console.WriteLine("your answer is correct! Exceelent job!\nAttempts:" + counter);
            }
            else
            {
                Console.WriteLine("Incorrect! try again!\nAttempts:" + counter);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
        }
    }
}
