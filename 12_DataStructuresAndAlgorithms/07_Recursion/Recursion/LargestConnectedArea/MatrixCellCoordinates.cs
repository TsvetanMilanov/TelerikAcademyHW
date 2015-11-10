namespace LargestConnectedArea
{
    using System;

    public class MatrixCellCoordinates : IComparable<MatrixCellCoordinates>
    {
        public MatrixCellCoordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public int CompareTo(MatrixCellCoordinates other)
        {
            if (this.Row < other.Row)
            {
                return -1;
            }
            else if (this.Row > other.Row)
            {
                return 1;
            }
            else if (this.Col < other.Col)
            {
                return -1;
            }
            else if (this.Col > other.Col)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override bool Equals(object obj)
        {
            MatrixCellCoordinates other = (MatrixCellCoordinates)obj;

            if (this.CompareTo(other) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
