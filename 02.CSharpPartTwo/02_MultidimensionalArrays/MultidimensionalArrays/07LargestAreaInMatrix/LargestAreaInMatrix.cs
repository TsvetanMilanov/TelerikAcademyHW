using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07LargestAreaInMatrix
{
    class LargestAreaInMatrix
    {
        static int length = 0;
        static int maxLength = 0;

        static int[,] matrix = new int[,] { { 1, 3, 2, 2, 2, 4 }, { 3, 3, 3, 2, 4, 4 }, { 4, 3, 1, 2, 3, 3 }, { 4, 3, 1, 3, 3, 1 }, { 4, 3, 3, 3, 1, 1 } };

        static void Main(string[] args)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    CheckElements(i, j, matrix[i, j]);

                    length = 0;
                }
            }

            Console.WriteLine("The maximal length is: {0}", maxLength);
        }

        private static void CheckElements(int currentRow, int currentCol, int currentElement)
        {
            //Checks the elements.

            //Check if indexes are out of range of the matrix.
            bool rowIsOutOfRange = currentRow >= matrix.GetLength(0) || currentRow < 0;
            bool colIsOutOfRange = currentCol >= matrix.GetLength(1) || currentCol < 0;

            //Check if the element is already checked.
            bool elementIsChecked = currentElement == 0;

            if (elementIsChecked || rowIsOutOfRange || colIsOutOfRange)
            {
                return;
            }

            if (matrix[currentRow, currentCol] == currentElement)
            {
                matrix[currentRow, currentCol] = 0;

                length++;

                if (maxLength < length)
                {
                    maxLength = length;
                }

                //Check neighbour elements.
                CheckElements(currentRow + 1, currentCol, currentElement);

                CheckElements(currentRow - 1, currentCol, currentElement);

                CheckElements(currentRow, currentCol + 1, currentElement);

                CheckElements(currentRow, currentCol - 1, currentElement);

                matrix[currentRow, currentCol] = currentElement;

            }

        }
    }
}
