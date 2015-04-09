namespace ArrayProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayMain
    {
        public static void Main(string[] args)
        {
            BitArray64 testArray = new BitArray64();
            testArray.Number = 7654947979917746498;

            BitArray64 secondTestArray = new BitArray64();
            secondTestArray.Number = 9654947979917746498;

            PrintBitArray(testArray);

            Console.WriteLine("First equals test: {0}", testArray.Equals(secondTestArray));

            Console.WriteLine("Second to string:\n{0}", secondTestArray.ToString());

            Console.WriteLine("Indexer test:\ntestArray[2] = {0}", testArray[2]);

            Console.WriteLine("Test array == second test array: {0}", testArray == secondTestArray);

            Console.WriteLine("Test array != second test array: {0}", testArray != secondTestArray);
        }

        private static void PrintBitArray(BitArray64 testArray)
        {
            Console.WriteLine("The bit array of number {0} is:", testArray.Number);

            foreach (var bit in testArray)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
        }
    }
}
