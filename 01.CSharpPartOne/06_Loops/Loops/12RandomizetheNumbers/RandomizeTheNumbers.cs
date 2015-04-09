using System;
using System.Collections.Generic;

/*Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 */

class RandomizeTheNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        //Add numbers to array
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        Random random = new Random();
        int randomIndex;
        int counter = 0;
        int indexOfArray = 0;
        bool doesNotContainIndex = true;

        List<int> listOfRandomIndexes = new List<int>();

        do
        {
            //Randomize index
            randomIndex = random.Next(0, n);

            if (counter == 0)
            {
                Console.Write("{0} ", numbers[randomIndex]);
                counter++;
            }
            else
            {
                //Check if index is used before
                for (int k = 0; k < listOfRandomIndexes.Capacity; k++)
                {
                    if (listOfRandomIndexes.Contains(randomIndex))
                    {
                        doesNotContainIndex = false;
                        break;
                    }
                    else
                    {
                        doesNotContainIndex = true;
                    }
                }
                //Print number if index is not used before
                if (doesNotContainIndex)
                {
                    Console.Write("{0} ", numbers[randomIndex]);
                    counter++;
                }
            }
            //Add the random index to the list of random indexes
            listOfRandomIndexes.Add(randomIndex);
            indexOfArray++;
        } while (counter < n);
        Console.WriteLine();
    }
}
