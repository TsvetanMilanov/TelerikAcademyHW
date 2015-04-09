using System;
using System.Text;

/*Problem 16.** Bit Exchange (Advanced)

Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.*/

class BitExchangeAdvanced
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.Write("Enter value for \"p\": ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter value for \"q\": ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Enter value for \"k\": ");
        int k = int.Parse(Console.ReadLine());

        if (((p < q) && ((p + k) > q)) || ((p > q) && (q + k > p)))
        {
            Console.WriteLine("overlapping");
        }
        else if (((p + k) > 32) || ((q + k) > 32) || ((p < 0) || (q < 0)))
        {
            Console.WriteLine("out of range");
        }
        else
        {

            string numberString = Convert.ToString(number, 2);
            StringBuilder firstStringBuilder = new StringBuilder(numberString);
            StringBuilder pStringBuilder = new StringBuilder("00000000000000000000000000000000");
            StringBuilder qStringBuilder = new StringBuilder("00000000000000000000000000000000");



            for (int i = 0; i < k; i++)
            {
                pStringBuilder[i] = numberString[(numberString.Length - 1 - p) - i];
                qStringBuilder[i] = numberString[(numberString.Length - 1 - q) - i];
            }

            for (int j = 0; j < k; j++)
            {
                firstStringBuilder[(firstStringBuilder.Length - 1 - p) - j] = qStringBuilder[j];
                firstStringBuilder[(firstStringBuilder.Length - 1 - q) - j] = pStringBuilder[j];
            }


            string binaryResult = firstStringBuilder.ToString();
            uint finalNumber = Convert.ToUInt32(binaryResult, 2);

            Console.WriteLine("\n{0}\t{1}\n", binaryResult, finalNumber);
        }
    }
}
