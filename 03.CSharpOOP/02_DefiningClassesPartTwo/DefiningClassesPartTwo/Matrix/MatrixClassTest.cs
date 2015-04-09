namespace MatrixClass
{
    using System;

    [Version(1, 0)]
    public class MatrixClassTest
    {
        public static void Main()
        {
            MatrixClass<int> matrixA = new MatrixClass<int>(2, 2);

            int number = 1;

            for (int i = 0; i < matrixA.XSize; i++)
            {
                for (int j = 0; j < matrixA.YSize; j++)
                {
                    matrixA[i, j] = number;
                    number++;
                }
            }

            Console.WriteLine("Matrix A is:");
            matrixA.PrintMatrix();

            Console.WriteLine("\nMatrix B is:");
            MatrixClass<int> matrixB = new MatrixClass<int>(2, 2);

            for (int i = 0; i < matrixA.XSize; i++)
            {
                for (int j = 0; j < matrixA.YSize; j++)
                {
                    matrixB[i, j] = number;
                    number++;
                }
            }

            matrixB.PrintMatrix();

            MatrixClass<int> matrixAPlusMatrixB = matrixA + matrixB;

            Console.WriteLine("\nA+B:");
            matrixAPlusMatrixB.PrintMatrix();

            MatrixClass<int> matrixAMinusMatrixB = matrixA - matrixB;

            Console.WriteLine("\nA-B:");
            matrixAMinusMatrixB.PrintMatrix();

            MatrixClass<int> matrixAMultipliedByMatrixB = matrixA * matrixB;

            Console.WriteLine("\nA*B:");
            matrixAMultipliedByMatrixB.PrintMatrix();

            bool nonZeroElements = true;

            if (matrixA)
            {
                nonZeroElements = true;
            }
            else
            {
                nonZeroElements = false;
            }

            Console.WriteLine("\nMatrix A contains non-zero elements: {0}", nonZeroElements);

            Type type = typeof(MatrixClassTest);

            var attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in attributes)
            {
                Console.WriteLine("\nThe version of class MatrixClassTest is: {0}.{1}\n", item.VersionMajor, item.VersionMinor);
            }
        }
    }
}
