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
        int count = 0;

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

        public void Game2(int[] array)
        {
            Random rand = new Random();
            target = rand.Next(1000);

            first = array[0];
            last = array[array.Length - 1];
            middle = (first + last) / 2;

            while (first <= middle)
            {
                if (target == middle)
                {
                    Console.WriteLine($"Congrats! The target number was {target}.");

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
