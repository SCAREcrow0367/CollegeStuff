using System;
using static System.Console;

//made by Kyler Moore


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
        private static void Main(string[]args)
        {
            char Animal;
            char Dog;
            char Puppy;
            char Cats;
            char Kittens;
            int Animal_total = 0;
            double puppy_price = 0;
            double cats_price = 0;
            double Dog_price = 0;
            double kitten_price = 0;
            double total_price = 0;
            Program ob = new Program();
            ob.PriceMenu();
            WriteLine("Would you like to purchase an Animal today? Y for yes, N for NO.");
            Animal = Convert.ToChar(ReadLine());
            while (Animal == 'y' || Animal == 'Y') 
            {
                WriteLine("what would you like to purchase? P for puppy, D for Dog, C for Cat, or K for Kitten");
                Puppy = Convert.ToChar(ReadLine());
                Dog = Convert.ToChar(ReadLine());
                Cats = Convert.ToChar(ReadLine());
                Kittens = Convert.ToChar(ReadLine());
                if ((Puppy == 'P') || (Puppy == 'p')) 
                {
                    WriteLine("How many would you like to buy?");
                    Animal_total = Convert.ToInt32(ReadLine());
                    switch (Animal_total)
                    {
                        case 1:
                            WriteLine("you have selected one puppy.");
                            ReadLine();
                            puppy_price = 500;
                            total_price = puppy_price;
                            break;
                        case 2:
                            WriteLine("your total for the two puppies is 1000$");
                            ReadLine();
                            puppy_price = 500;
                            total_price = puppy_price * Animal_total;
                            break;
                        case 3:
                            WriteLine("your total for the three puppies is 1500$");
                            ReadLine();
                            puppy_price = 500;
                            total_price = puppy_price * Animal_total;
                            break;
                        case 4:
                            WriteLine("your total for the three puppies is 1500$");
                            ReadLine();
                            puppy_price = 500;
                            total_price = puppy_price * Animal_total;
                            break;
                        case 5:
                            WriteLine("your total for the three puppies is 1500$");
                            ReadLine();
                            puppy_price = 500;
                            total_price = puppy_price * Animal_total;
                            break;
                        case 6:
                            WriteLine("your total for the three puppies is 1500$");
                            ReadLine();
                            puppy_price = 500;
                            total_price = puppy_price * Animal_total;
                            break;
                        case 7:
                            WriteLine("your total for the three puppies is 1500$");
                            ReadLine();
                            puppy_price = 500;
                            total_price = puppy_price * Animal_total;
                            break;
                        case 8:
                            WriteLine("your total for the three puppies is 1500$");
                            ReadLine();
                            puppy_price = 500;
                            total_price = puppy_price * Animal_total;
                            break;
                        case 9:
                            WriteLine("your total for the three puppies is 1500$");
                            ReadLine();
                            puppy_price = 500;
                            total_price = puppy_price * Animal_total;
                            break;
                        default:
                            WriteLine("You have not input a valid amount for how many puppies you'd like.");
                            ReadLine();
                            break;
                    }
                    if ((Dog == 'D') || (Dog == 'd')) 
                    WriteLine("How many would you like to buy?");
                    Animal_total = Convert.ToInt32(ReadLine());
                    switch (Animal_total)
                    {
                        case 1:
                            WriteLine("you have selected one Dog for 800$.");
                            ReadLine();
                            Dog_price = 800;
                            total_price = Dog_price;
                            break;
                        case 2:
                            WriteLine("your total for the two Dogs is 1600$");
                            ReadLine();
                            Dog_price = 800;
                            total_price = Dog_price * Animal_total;
                            break;
                        case 3:
                            WriteLine("your total for the three Dogs is 2400$");
                            ReadLine();
                            Dog_price = 800;
                            total_price = Dog_price * Animal_total;
                            break;
                        case 4:
                            WriteLine("your total for the three Dogs is 3200$");
                            ReadLine();
                            Dog_price = 800;
                            total_price = Dog_price * Animal_total;
                            break;
                        case 5:
                            WriteLine("your total for the three Dogs is 4000$");
                            ReadLine();
                            Dog_price = 800;
                            total_price = Dog_price * Animal_total;
                            break;
                        case 6:
                            WriteLine("your total for the three Dogs is 4800$");
                            ReadLine();
                            Dog_price = 800;
                            total_price = Dog_price * Animal_total;
                            break;
                        case 7:
                            WriteLine("your total for the three Dogs is 5600$");
                            ReadLine();
                            Dog_price = 800;
                            total_price = Dog_price * Animal_total;
                            break;
                        case 8:
                            WriteLine("your total for the three Dogs is 6400$");
                            ReadLine();
                            Dog_price = 800;
                            total_price = Dog_price * Animal_total;
                            break;
                        case 9:
                            WriteLine("your total for the three Dogs is 7200$");
                            ReadLine();
                            Dog_price = 800;
                            total_price = Dog_price * Animal_total;
                            break;
                        default:
                            WriteLine("You have not input a valid amount for how many Dogs you'd like.");
                            ReadLine();
                            break;
                    }
                    if ((Cats == 'C') || (Cats == 'c')) 
                    WriteLine("How many would you like to buy?");
                    Animal_total = Convert.ToInt32(ReadLine());
                    switch (Animal_total)
                    {
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
                            total_price = cats_price * Animal_total;
                            break;
                        case 3:
                            WriteLine("your total for the three cats is 1950$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Animal_total;
                            break;
                        case 4:
                            WriteLine("your total for the three cats is 2600$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Animal_total;
                            break;
                        case 5:
                            WriteLine("your total for the three cats is 3150$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Animal_total;
                            break;
                        case 6:
                            WriteLine("your total for the three cats is 3800$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Animal_total;
                            break;
                        case 7:
                            WriteLine("your total for the three cats is 4550$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Animal_total;
                            break;
                        case 8:
                            WriteLine("your total for the three cats is 5200$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Animal_total;
                            break;
                        case 9:
                            WriteLine("your total for the three cats is 6850$");
                            ReadLine();
                            cats_price = 650;
                            total_price = cats_price * Animal_total;
                            break;
                        default:
                            WriteLine("You have not input a valid amount for how many cats you'd like.");
                            ReadLine();
                            break;
                    }
                    if ((Kittens == 'k') || (Kittens == 'K')) 
                    WriteLine("How many would you like to buy?");
                    Animal_total = Convert.ToInt32(ReadLine());
                    switch (Animal_total)
                    {
                        case 1:
                            WriteLine("you have selected one kitten for a total of 350$.");
                            ReadLine();
                            kitten_price = 350;
                            total_price = kitten_price;
                            break;
                        case 2:
                            WriteLine("your total for the two kittens is 700$");
                            ReadLine();
                            kitten_price = 350;
                            total_price = kitten_price * Animal_total;
                            break;
                        case 3:
                            WriteLine("your total for the three kittens is 1050$");
                            ReadLine();
                            kitten_price = 350;
                            total_price = kitten_price * Animal_total;
                            break;
                        case 4:
                            WriteLine("your total for the three kittens is 1400$");
                            ReadLine();
                            kitten_price = 350;
                            total_price = kitten_price * Animal_total;
                            break;
                        case 5:
                            WriteLine("your total for the three kittens is 1750$");
                            ReadLine();
                            kitten_price = 350;
                            total_price = kitten_price * Animal_total;
                            break;
                        case 6:
                            WriteLine("your total for the three kittens is 2100$");
                            ReadLine();
                            kitten_price = 350;
                            total_price = kitten_price * Animal_total;
                            break;
                        case 7:
                            WriteLine("your total for the three kittens is 2450$");
                            ReadLine();
                            kitten_price = 350;
                            total_price = kitten_price * Animal_total;
                            break;
                        case 8:
                            WriteLine("your total for the three kittens is 2800$");
                            ReadLine();
                            kitten_price = 350;
                            total_price = kitten_price * Animal_total;
                            break;
                        case 9:
                            WriteLine("your total for the three kittens is 3150$");
                            ReadLine();
                            kitten_price = 350;
                            total_price = kitten_price * Animal_total;
                            break;
                        default:
                            WriteLine("You have not input a valid amount for how many kittens you'd like.");
                            ReadLine();
                            break;
                    }
                }

            }
        }
    }
}