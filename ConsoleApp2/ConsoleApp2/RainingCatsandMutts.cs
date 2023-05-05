using System;
using static System.Console;


namespace RainingCatsandMutts
{
    class Program
    {
        private void PriceMenu()
        {
            WriteLine("A puppy is 500$");
            WriteLine("We also have kittens, they're 350");
            WriteLine("If you prefer, we have dogs instead for 800");
            WriteLine("Also have Cats for 650");
            WriteLine("you are more than welcomed to purchase more than one animal. ");
            WriteLine("You can have a maximum of 9 animals, so please don't be scared to buy your dream animals.");
        }
        private static void Main()
        {
            char usercontinue;
            char Animals;
            char Dog;
            char Puppy;
            char Cats;
            char Kittens;
            int Dogs_total = 0;
            int Cats_total = 0;
            int Puppy_total = 0;
            int Kittens_total = 0;
            const double puppy_price = 500;
            const double cats_price = 650;
            const  double Dog_price = 800;
            const double kitten_price = 3500;
            double total_price = 0;
            Program ob = new Program();
            ob.PriceMenu();
            WriteLine("Would you like to purchase an animal today? Y for yes, N for NO.");
            Animals = Convert.ToChar(ReadLine());
            while ((Animals == 'y') || (Animals == 'Y'))
            {
                WriteLine("what would you like to purchase? P for puppy, D for Dog, C for Cat, or K for Kitten");
                Dog = Convert.ToChar(ReadLine());
                Cats = Convert.ToChar(ReadLine());
                Puppy = Convert.ToChar(ReadLine());
                Kittens = Convert.ToChar(ReadLine());
                if ((Puppy == 'P') || (Puppy == 'p'))
                {
                    WriteLine("How many would you like to buy?");
                    Puppy_total = Convert.ToInt32(ReadLine());
                    switch (Puppy_total)
                    {
                        case 1:
                            WriteLine("you have selected one puppy for a total of 500$");
                            ReadLine();
                            total_price = puppy_price;
                            break;
                        case 2:
                            WriteLine("your total for the two puppies is 1000$");
                            ReadLine();
                            total_price = puppy_price * Puppy_total;
                            break;
                        case 3:
                            WriteLine("your total for the three puppies is 1500$");
                            ReadLine();
                            total_price = puppy_price * Puppy_total;
                            break;
                        case 4:
                            WriteLine("your total for the four puppies is 2000$");
                            ReadLine();
                            total_price = puppy_price * Puppy_total;
                            break;
                        case 5:
                            WriteLine("your total for the five puppies is 2500$");
                            ReadLine();
                            total_price = puppy_price * Puppy_total;
                            break;
                        case 6:
                            WriteLine("your total for the six puppies is 3000$");
                            ReadLine();
                            total_price = puppy_price * Puppy_total;
                            break;
                        case 7:
                            WriteLine("your total for the seven puppies is 3500$");
                            ReadLine();
                            total_price = puppy_price * Puppy_total;
                            break;
                        case 8:
                            WriteLine("your total for the eight puppies is 4000$");
                            ReadLine();
                            total_price = puppy_price * Puppy_total;
                            break;
                        case 9:
                            WriteLine("your total for the nine puppies is 4500$");
                            ReadLine();
                            total_price = puppy_price * Puppy_total;
                            break;
                        default:
                            WriteLine("You have not input a valid amount for how many puppies you'd like.");
                            ReadLine();
                            break;
                    }
                    
                        else if ((Dog == 'D') || (Dog == 'd'))
                            WriteLine("How many would you like to buy?");
                        Dogs_total = Convert.ToInt32(ReadLine());
                    switch (Dogs_total)
                    {
                        case 1:
                            WriteLine("you have selected one Dog for 800$.");
                            ReadLine();
                            total_price = Dog_price;
                            break;
                        case 2:
                            WriteLine("your total for the two Dogs is 1600$");
                            ReadLine();
                            total_price = Dog_price * Dogs_total;
                            break;
                        case 3:
                            WriteLine("your total for the three Dogs is 2400$");
                            ReadLine();
                            total_price = Dog_price * Dogs_total;
                            break;
                        case 4:
                            WriteLine("your total for the three Dogs is 3200$");
                            ReadLine();
                            total_price = Dog_price * Dogs_total;
                            break;
                        case 5:
                            WriteLine("your total for the three Dogs is 4000$");
                            ReadLine();
                            total_price = Dog_price * Dogs_total;
                            break;
                        case 6:
                            WriteLine("your total for the three Dogs is 4800$");
                            ReadLine();
                            total_price = Dog_price * Dogs_total;
                            break;
                        case 7:
                            WriteLine("your total for the three Dogs is 5600$");
                            ReadLine();
                            total_price = Dog_price * Dogs_total;
                            break;
                        case 8:
                            WriteLine("your total for the three Dogs is 6400$");
                            ReadLine();
                            total_price = Dog_price * Dogs_total;
                            break;
                        case 9:
                            WriteLine("your total for the three Dogs is 7200$");
                            ReadLine();
                            total_price = Dog_price * Dogs_total;
                            break;
                        default:
                            WriteLine("You have not input a valid amount for how many Dogs you'd like.");
                            ReadLine();
                            break;
                    }
                        
                        else if ((Cats == 'C') || (Cats == 'c'))
                        {    WriteLine("How many Cats would you like to buy?");
                            Cats_total = Convert.ToInt32(ReadLine());
                        switch (Cats_total)


                            case 1:
                            WriteLine("you have selected one cat for a total of 650$.");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price;
                            break;
                        case 2:
                            WriteLine("your total for the two cats is 1300$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Cats_total;
                            break;
                        case 3:
                            WriteLine("your total for the three cats is 1950$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Cats_total;
                            break;
                        case 4:
                            WriteLine("your total for the three cats is 2600$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Cats_total;
                            break;
                        case 5:
                            WriteLine("your total for the three cats is 3150$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Cats_total;
                            break;
                        case 6:
                            WriteLine("your total for the three cats is 3800$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Cats_total;
                            break;
                        case 7:
                            WriteLine("your total for the three cats is 4550$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Cats_total;
                            break;
                        case 8:
                            WriteLine("your total for the three cats is 5200$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Cats_total;
                            break;
                        case 9:
                            WriteLine("your total for the three cats is 6850$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Cats_total;
                            break;
                        default:
                            WriteLine("You have not input a valid amount for how many cats you'd like.");
                            ReadLine();
                            break;
                        }
                        
                        else if ((Kittens == 'k') || (Kittens == 'K'))
                            WriteLine("How many would you like to buy?");
                        Kittens_total = Convert.ToInt32(ReadLine());
                        switch (Kittens_total)
                        {
                            case 1:
                                WriteLine("you have selected one kitten for a total of 350$.");
                                ReadLine();
                                total_price = kitten_price;
                                break;
                            case 2:
                                WriteLine("your total for the two kittens is 700$");
                                ReadLine();
                                total_price = kitten_price * Kittens_total;
                                break;
                            case 3:
                                WriteLine("your total for the three kittens is 1050$");
                                ReadLine();
                                total_price = kitten_price * Kittens_total;
                                break;
                            case 4:
                                WriteLine("your total for the three kittens is 1400$");
                                ReadLine();
                                total_price = kitten_price * Kittens_total;
                                break;
                            case 5:
                                WriteLine("your total for the three kittens is 1750$");
                                ReadLine();
                                total_price = kitten_price * Kittens_total;
                                break;
                            case 6:
                                WriteLine("your total for the three kittens is 2100$");
                                ReadLine();
                                total_price = kitten_price * Kittens_total;
                                break;
                            case 7:
                                WriteLine("your total for the three kittens is 2450$");
                                ReadLine();
                                total_price = kitten_price * Kittens_total;
                                break;
                            case 8:
                                WriteLine("your total for the three kittens is 2800$");
                                ReadLine();
                                total_price = kitten_price * Kittens_total;
                                break;
                            case 9:
                                WriteLine("your total for the three kittens is 3150$");
                                ReadLine();
                                total_price = kitten_price * Kittens_total;
                                break;
                            default:
                                WriteLine("You have not input a valid amount for how many kittens you'd like.");
                                ReadLine();
                                break;
                        }
                        else
                        {
                        WriteLine("You did not enter a valid item.");
                        }
                }
                WriteLine("Thank you for your purchase, please press any key to finish.");
                usercontinue = Convert.ToChar(ReadLine());

            }
        }
    }
}