using System;

namespace MatrixNamespace
{
    public class Matrix
    {
        private int[,] matrix;

        //Get property.
        public int GetRows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        //Get property.
        public int GetCols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        //Add method.
        public static Matrix Add(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix result = new Matrix(firstMatrix.GetRows, firstMatrix.GetCols);

            for (int i = 0; i < firstMatrix.GetRows; i++)
            {
                for (int j = 0; j < firstMatrix.GetCols; j++)
                {
                    result[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return result;
        }

        //Use operator + for adding.
        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            return Add(firstMatrix, secondMatrix);
        }

        //Substract method.
        public static Matrix Substract(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix result = new Matrix(firstMatrix.GetRows, firstMatrix.GetCols);

            for (int i = 0; i < firstMatrix.GetRows; i++)
            {
                for (int j = 0; j < firstMatrix.GetCols; j++)
                {
                    result[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return result;
        }

        //Use operator - for substracting.
        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            return Substract(firstMatrix, secondMatrix);
        }

        //Multiply method.
        public static Matrix Multiply(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix result = new Matrix(firstMatrix.GetRows, firstMatrix.GetCols);

            int temp = 0;

            for (int row = 0; row < firstMatrix.GetRows; row++)
            {
                for (int col = 0; col < secondMatrix.GetCols; col++)
                {
                    temp = 0;
                    for (int k = 0; k < firstMatrix.GetCols; k++)
                    {
                        temp = temp + firstMatrix[row, k] * secondMatrix[k, col];
                    }
                    result[row, col] = temp;
                }
            }

            return result;
        }

        //Use operator * for multiplying.
        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            return Multiply(firstMatrix, secondMatrix);
        }


        //Constructor.
        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
        }

        //Indexes.
        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        //ToString() method.
        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < this.GetRows; i++)
            {
                for (int j = 0; j < this.GetCols; j++)
                {
                    result += this[i, j];
                    result += " ";
                }
                result += "\n";
            }

            return result;
        }

    }
}