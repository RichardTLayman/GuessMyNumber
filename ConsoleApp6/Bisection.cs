using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Bisection
    {
        public int[] tenCount = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public int[] thousandCount = Enumerable.Range(1, 1000).ToArray();

        int first;
        int middle;
        int last;
        int target;
        int guess;
        int count;

        public void Games()
        {
            Console.WriteLine("Press 1 to implement the bisection algorithm:");
            Console.WriteLine("Press 2 to guess a number chosen by the computer:");
            //Console.WriteLine("Press 3 to have the computer guess bisection algorithm:");

            int value = Convert.ToInt32(Console.ReadLine());

            while (value != 1 || value != 2)
            {
                Console.WriteLine("Press 1 to implement the bisection algorithm:");
                Console.WriteLine("Press 2 to guess a number chosen by the computer:");
                //Console.WriteLine("Press 3 to have the computer guess bisection algorithm:");

                value = Convert.ToInt32(Console.ReadLine());
            }

            switch (value)
            {
                case 1:
                    Game1(tenCount);
                    break;
                case 2:
                    Game2(thousandCount);
                    break;
                default:
                    break;
            }

        }

        public void Game1(int[] array)
        {
            first = array[0];
            last = array[array.Length - 1];
            middle = (first + last) / 2;

            Console.WriteLine("Please select a number between 1 and 10.");
            target = Convert.ToInt32(Console.ReadLine());

            while (target <= 0 || target > 10)
            {
                Console.WriteLine("Please select a number between 1 and 10.");
                target = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            while (first <= middle)
            {
                if (target == middle)
                {
                    Console.WriteLine($"Congrats! The target number was {target}.");            
                    break;
                }
                else if (target < middle)
                {
                    Console.WriteLine("The target is smaller.");
                    last = middle - 1;
                    middle = (first + last) / 2;
                }
                else
                {
                    Console.WriteLine("the target is higher.");
                    first = middle + 1;
                    middle = (first + last) / 2;
                }
                Console.ReadKey();
            }
        }

        public void Game2(int[] array)
        {
            Random rand = new Random();
            target = rand.Next(1000);

            first = array[0];
            last = array[array.Length - 1];
            middle = (first + last) / 2;

            count = 0;

            while (guess != target)
            {
                count++;
                Console.WriteLine($"Please select a number between {first} and {last}.");
                guess = Convert.ToInt32(Console.ReadLine());

                while (guess == 0 || guess < first || guess > last)
                {
                    Console.WriteLine($"Please select a number between {first} and {last}.");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                if (target == guess)
                {
                    Console.WriteLine($"Congrats! You guessed the right number.");
                    Console.WriteLine($"It took you {count} guesses.");
                    break;
                }
                else if (target < middle)
                {
                    Console.WriteLine(middle);
                    Console.WriteLine("The target is smaller.");
                    last = middle - 1;
                    middle = (first + last) / 2;
                }
                else
                {
                    Console.WriteLine(middle);
                    Console.WriteLine("the target is higher.");
                    first = middle + 1;
                    middle = (first + last) / 2;
                }
                Console.ReadKey();
            }
        }
    }
}
