using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15NumberCaclulations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            double minValue = Minimum(1.2, 2, 3, 4, 5, 6);
            Console.WriteLine("The min value is: {0}", minValue);

            int maxValue = Maximum(1, 2, 3, 4, 5, 6);
            Console.WriteLine("The max value is: {0}", maxValue);

            double averageValue = Average(1.5, 2, 3, 4, 5, 6);
            Console.WriteLine("The average value is: {0:F3}", averageValue);

            int sumValue = Sum(1, 2, 3, 4, 5, 6);
            Console.WriteLine("The sum is: {0}", sumValue);

            int productValue = Product(1, 2, 3, 4, 5, 6);
            Console.WriteLine("The product is: {0}", productValue);

        }

        private static T Minimum<T>(params T[] numbers) where T : IComparable
        {
            T result = default(T);
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (i == 0)
                {
                    result = numbers[i];
                    continue;
                }
                else
                {
                    if (result.CompareTo(numbers[i]) > 0)
                    {
                        result = numbers[i];
                    }
                }

            }

            return result;
        }

        private static T Maximum<T>(params T[] numbers) where T : IComparable
        {
            T result = default(T);

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (result.CompareTo(numbers[i]) < 0)
                {
                    result = numbers[i];
                }
            }

            return result;
        }

        private static T Average<T>(params T[] numbers) where T : IComparable
        {
            dynamic result = numbers[0];

            for (int i = 1; i < numbers.GetLength(0); i++)
            {
                result += numbers[i];
            }

            result /= numbers.Length;
            return result;
        }

        private static T Sum<T>(params T[] numbers) where T : IComparable
        {
            dynamic result = numbers[0];

            for (int i = 1; i < numbers.GetLength(0); i++)
            {
                result += numbers[i];
            }

            return result;
        }

        private static T Product<T>(params T[] numbers) where T : IComparable
        {
            dynamic result = numbers[0];

            for (int i = 1; i < numbers.GetLength(0); i++)
            {
                result *= numbers[i];
            }

            return result;
        }
    }
}
