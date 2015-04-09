using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */

namespace _15PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            //If you want the prime numbers from 1 to 10 000 000 change the numbersCount, but it will take LONG time to calculate.
            long numbersCount = 10000;
            List<long> numbers = new List<long>();

            for (long i = 2; i <= numbersCount; i++)
            {
                numbers.Add(i);
            }
            numbers.TrimExcess();

            RemoveNumbers(numbersCount, numbers);

            string result = string.Join(", ", numbers);
            Console.WriteLine(result);
        }

        private static void RemoveNumbers(long numbersCount, List<long> numbers)
        {

            for (long i = 2, j = 3, k = 5, l = 7; i <= numbersCount; i += 2, j += 3, k += 5, l += 7)
            {
                if (i == 2 || j == 3 || k == 5 || l == 7)
                {
                    continue;
                }

                numbers.Remove(i);
                numbers.Remove(j);
                numbers.Remove(k);
                numbers.Remove(l);
            }
            numbers.TrimExcess();
        }
    }
}
