using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixNamespace;

/*Problem 6.* Matrix class

Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices,
indexer for accessing the matrix content and ToString().
 */

namespace _06MatrixClass
{
    class MatrixClass
    {
        static void Main(string[] args)
        {
            Matrix firstMatrix = new Matrix(2, 2);

            Matrix secondMatrix = new Matrix(2, 2);

            firstMatrix = InitMatrix(firstMatrix);
            secondMatrix = InitMatrix(secondMatrix);

            Matrix addWithMethod = Matrix.Add(firstMatrix, secondMatrix);
            Matrix addWithSign = firstMatrix + secondMatrix;

            Console.WriteLine("Add with method:\n{0}", addWithMethod);
            Console.WriteLine("Add with sign:\n{0}", addWithSign);

            Matrix substractWithMethod = Matrix.Substract(firstMatrix, secondMatrix);
            Matrix substractwithSign = firstMatrix - secondMatrix;

            Console.WriteLine("Substract with method:\n{0}", substractWithMethod);
            Console.WriteLine("Substract with sign:\n{0}", substractwithSign);

            Matrix multiplyWithMethod = Matrix.Multiply(firstMatrix, secondMatrix);
            Matrix multiplyWithSign = firstMatrix * secondMatrix;

            Console.WriteLine("Multiply with method:\n{0}", multiplyWithMethod);
            Console.WriteLine("Multiply with sign:\n{0}", multiplyWithSign);

        }

        private static Matrix InitMatrix(Matrix matrix)
        {
            int number = 1;

            for (int i = 0; i < matrix.GetRows; i++)
            {
                for (int j = 0; j < matrix.GetCols; j++)
                {
                    matrix[i, j] = number;
                    number++;
                }
            }

            return matrix;
        }
    }
}
