using System;
using System.Linq;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArr(arrA);

            Random rd = new Random();
            int guess = 0;
            Console.WriteLine("The computer will generate a random number between 1 and 10.");
            guess = UserInput(guess);
            RngTenDigits(arrA, guess);
            Console.WriteLine("The computer will generate a random number between 1 and 1000."); guess = UserInput(guess);
            GuessMyNumber(rd.Next(1000), guess);
            Console.WriteLine("The computer will now play a number between 1 and 100.");
            ComputerPlays(0, 1000, 0);
        }

        static void PrintArr(int[] arr)
        {
            Console.WriteLine("Array Elements: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}\n");
        }

        static int UserInput(int userInt_)
        {
            bool validInp = false;
            while (validInp == false)
            {
                try
                {
                    userInt_ = Convert.ToInt32(Console.ReadLine());

                    if (userInt_ < 0)
                    {
                        Console.WriteLine("You must enter a positive number.  Try again.");
                        userInt_ = Convert.ToInt32(Console.ReadLine());
                    }
                    validInp = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number, input string not in a correct format.");
                }
            }
            return userInt_;
        }

        static int RngTenDigits(int[] arr, int userInt_)
        {
            Console.WriteLine("Input a guess between 1 and 10.");
            Random rd = new Random();
            int arrNum = arr[rd.Next(0, arr.Length)];
            int count = 0;
            if (userInt_ < arrNum || userInt_ > arrNum)
            {
                do
                {
                    count++;
                    if (userInt_ < arrNum)
                    {
                        Console.WriteLine("Your number was too low.  Input another number.");
                        userInt_ = Convert.ToInt32(Console.ReadLine());
                    }

                    else if (userInt_ > arrNum)
                    {
                        Console.WriteLine("Your number was too high.  Input another number.");
                        userInt_ = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine($"Your input was {userInt_} and the RNG value is {arrNum}");
                    }
                } while (userInt_ < arrNum || userInt_ > arrNum);
            }
            Console.WriteLine($"Your input was {userInt_} and the RNG value is {arrNum}.  You tried {count} times.");

            return userInt_;
        }

        static int GuessMyNumber(int rng, int guess)
        {
            Console.WriteLine("Input a guess between 1 and 1000.");
            int count = 0;

            do
            {
                count++;
                if (guess < rng)
                {
                    Console.WriteLine("Your number was too low.  Input another number.");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                else if (guess > rng)
                {
                    Console.WriteLine("Your number was too high.  Input another number.");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Your input was {guess} and the RNG value is {rng}.  You tried {count} times.");
                }
            } while (guess < rng || guess > rng);
            Console.WriteLine($"Your input was {guess} and the RNG value is {rng}.  You tried {count} times.");

            return guess;
        }

        static int ComputerPlays(int a, int b, int count)
        {
            count++;
            Console.WriteLine("Input 1 if the play is too high, input 2 if play is too low.  Input 3 if the play is correct.");
            int c = (a + b) / 2;
            Console.WriteLine($"Computer played: {c}");

            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == 1)
            {
                b = c;
                Console.WriteLine($"Computer played: {c}");
                Console.WriteLine("Computer recalcuating, guess was overshot...");
                return ComputerPlays(a, b, count);
            }

            else if (guess == 2)
            {
                a = c;
                Console.WriteLine("Computer recalcuating, guess was undershot...");
                return ComputerPlays(a, b, count);

            }

            else if (guess == 3)
            {
                Console.WriteLine($"The computer played {c}.  The amount of plays the computer took to get the answer correct was {count}");
            }

            return count;
        }
    }
}
