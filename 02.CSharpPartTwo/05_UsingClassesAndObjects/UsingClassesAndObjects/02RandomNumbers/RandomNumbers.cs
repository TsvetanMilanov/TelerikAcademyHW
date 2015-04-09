using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

namespace _02RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomNumber.Next(100, 201));
            }
        }
    }
}
