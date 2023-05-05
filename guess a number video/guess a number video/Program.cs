using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_a_number_video
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string [] Words = { "Chess, Hockey, Basketball, Football, Baseball, Gymnastics, Tennis, Track" };
            int randomWords;
            int guess;
            int numberofguesses = 5;
            bool gameOver = false;

            Console.WriteLine("I'm thinking of a word. What word is it?");
            Console.WriteLine(Words);

            while (gameOver == false)
            {
                guess = Convert.ToChar(Console.ReadLine());
                numberofguesses--;

                if (guess != randomWords && numberofguesses == 0)
                {
                    Console.WriteLine("I mean, after five tries. We might as well just stop.");
                    gameOver = true;
                }
                else if (guess == randomWords)
                {
                    Console.WriteLine("That's it! You've cracked my word choice! YOU WIN!!!!");
                }
            }
            Console.ReadLine();
        }
    }
}
