using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
 */

namespace _08MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            //For console input:
            //int[] numbers = InitArray();

            int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int sizeOfArray = numbers.Length;

            int currentNumber = 0;
            int nextNumber = 0;
            int sum = numbers[0];
            int maxSum = numbers[0];

            bool flagNewSum = false;

            List<int> sequence = new List<int>();
            var maxSequence = sequence.ToList();

            sequence.Add(numbers[0]);
            maxSequence = sequence.ToList();
            for (int i = 1; i < sizeOfArray; i++)
            {
                currentNumber = numbers[i];

                //If the new sum starts with negative number skip the current negative number and go to the next without adding it to the sum.
                if (flagNewSum && currentNumber < 0)
                {
                    continue;
                }

                //Find the next elements for the tests.
                if (i <= sizeOfArray - 2)
                {
                    nextNumber = numbers[i + 1];
                }

                //If the number is negative  and the nex number is bigger than the current number enter this if statement.
                if (currentNumber < 0 && currentNumber < nextNumber)
                {
                    //If the sum of the current number and the next number is less or equal to zero stop adding to the sum and check the current sum and the maxSum.
                    if (nextNumber < 0 || currentNumber + nextNumber <= 0)
                    {
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxSequence.Clear();
                            maxSequence = sequence.ToList();
                            sequence.Clear();
                            sum = 0;
                            flagNewSum = true;
                        }
                        else if (sum < maxSum)
                        {
                            sequence.Clear();
                        }
                    }
                    else if (nextNumber > 0) //If the next number is positive add it to the sum, because the sum of current and next will be greater than zero (see above if).
                    {
                        sum += currentNumber;
                        sequence.Add(currentNumber);
                        flagNewSum = false;
                    }

                }

                //Old test of the numbers but if the program is not working please uncomment it and try it :D.
                //else if (currentNumber < 0 && currentNumber > nextNumber)
                //{
                //    sum += currentNumber;
                //    sequence.Add(currentNumber);
                //    flagNewSum = false;
                //}

                //If the number is positive add it to the sum.
                if (currentNumber >= 0)
                {
                    sum += currentNumber;
                    sequence.Add(currentNumber);
                    flagNewSum = false;
                }
            }

            //Check if the last sum is greater than the current maxSum and if so - swap them.
            if (sum > maxSum)
            {
                maxSum = sum;
                maxSequence.Clear();
                maxSequence = sequence.ToList();
                sequence.Clear();
                sum = 0;
            }

            string result = string.Join(", ", maxSequence);
            Console.WriteLine(result);
        }

        static int[] InitArray()
        {
            //Initializes an int array.

            Console.Write("Enter the size of the array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] array = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            return array;
        }

    }
}
