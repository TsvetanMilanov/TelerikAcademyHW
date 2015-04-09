using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
 */

namespace _14IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            int minValue = Minimum(1, 2, 3, 4, 5, 6);
            Console.WriteLine("The min value is: {0}", minValue);

            int maxValue = Maximum(1, 2, 3, 4, 5, 6);
            Console.WriteLine("The max value is: {0}", maxValue);

            decimal averageValue = Average(1, 2, 3, 4, 5, 6);
            Console.WriteLine("The average value is: {0}", averageValue);

            int sumValue = Sum(1, 2, 3, 4, 5, 6);
            Console.WriteLine("The sum is: {0}", sumValue);

            int productValue = Product(1, 2, 3, 4, 5, 6);
            Console.WriteLine("The product is: {0}", productValue);

        }

        private static int Minimum(params int[] numbers)
        {
            int result = int.MaxValue;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (numbers[i] < result)
                {
                    result = numbers[i];
                }
            }

            return result;
        }

        private static int Maximum(params int[] numbers)
        {
            int result = int.MinValue;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (numbers[i] > result)
                {
                    result = numbers[i];
                }
            }

            return result;
        }

        private static decimal Average(params int[] numbers)
        {
            decimal result = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                result += numbers[i];
            }

            result /= numbers.Length;
            return result;
        }

        private static int Sum(params int[] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                result += numbers[i];
            }

            return result;
        }

        private static int Product(params int[] numbers)
        {
            int result = 1;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                result *= numbers[i];
            }

            return result;
        }
    }
}
