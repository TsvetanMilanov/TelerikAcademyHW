namespace MatrixClass
{
    using System;

    public class MatrixClass<T> where T : struct
    {
        private T[,] matrix;

        public MatrixClass(int sizeX, int sizeY)
        {
            this.XSize = sizeX;
            this.YSize = sizeY;
            this.Matrix = new T[this.XSize, this.YSize];
        }

        public int XSize { get; private set; }

        public int YSize { get; private set; }

        private T[,] Matrix
        {
            get
            {
                return this.matrix;
            }

            set
            {
                this.matrix = value;
            }
        }

        public T this[int indexX, int indexY]
        {
            get
            {
                if (indexX >= this.XSize || indexY >= this.YSize)
                {
                    throw new IndexOutOfRangeException("The index was out of the matrix.");
                }

                return this.Matrix[indexX, indexY];
            }

            set
            {
                if (indexX >= this.XSize || indexY >= this.YSize)
                {
                    throw new IndexOutOfRangeException("The index was out of the matrix.");
                }

                this.Matrix[indexX, indexY] = value;
            }
        }

        public static MatrixClass<T> operator +(MatrixClass<T> firstMatrix, MatrixClass<T> secondMatrix)
        {
            MatrixClass<T> result = new MatrixClass<T>(firstMatrix.XSize, firstMatrix.YSize);

            for (int i = 0; i < firstMatrix.XSize; i++)
            {
                for (int j = 0; j < firstMatrix.YSize; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return result;
        }

        public static MatrixClass<T> operator -(MatrixClass<T> firstMatrix, MatrixClass<T> secondMatrix)
        {
            MatrixClass<T> result = new MatrixClass<T>(firstMatrix.XSize, firstMatrix.YSize);

            for (int i = 0; i < firstMatrix.XSize; i++)
            {
                for (int j = 0; j < firstMatrix.YSize; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return result;
        }

        public static MatrixClass<T> operator *(MatrixClass<T> firstMatrix, MatrixClass<T> secondMatrix)
        {
            MatrixClass<T> result = new MatrixClass<T>(firstMatrix.XSize, firstMatrix.YSize);

            for (int i = 0; i < firstMatrix.XSize; i++)
            {
                for (int j = 0; j < firstMatrix.YSize; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] * secondMatrix[j, i];
                }
            }

            return result;
        }

        public static bool operator true(MatrixClass<T> matrix)
        {
            bool result = true;

            for (int i = 0; i < matrix.XSize; i++)
            {
                for (int j = 0; j < matrix.YSize; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        result = false;
                    }
                }
            }

            return result;
        }

        public static bool operator false(MatrixClass<T> matrix)
        {
            bool result = false;

            for (int i = 0; i < matrix.XSize; i++)
            {
                for (int j = 0; j < matrix.YSize; j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < this.XSize; i++)
            {
                for (int j = 0; j < this.YSize; j++)
                {
                    Console.Write("{0,3}", this.Matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
