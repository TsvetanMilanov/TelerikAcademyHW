using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/*Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
 */

namespace _10NFactorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            int n = 1;
            BigInteger[] factorialsArray = new BigInteger[100];

            for (int i = 0; i < 100; i++, n++)
            {
                factorialsArray[i] = CalculateFactorial(n);
                Console.WriteLine("{0}! = {1}\n", n, factorialsArray[i]);
            }


        }

        static BigInteger CalculateFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= (BigInteger)i;
            }

            return factorial;
        }
    }
}
