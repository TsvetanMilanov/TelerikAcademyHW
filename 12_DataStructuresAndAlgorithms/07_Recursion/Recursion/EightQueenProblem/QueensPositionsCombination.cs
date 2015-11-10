namespace EightQueenProblem
{
    using System;

    public class QueensPositionsCombination : IComparable<QueensPositionsCombination>
    {
        private int[,] board;

        public QueensPositionsCombination(int[,] board)
        {
            this.board = board;
        }

        public int CompareTo(QueensPositionsCombination other)
        {
            for (int i = 0; i < this.board.GetLength(0); i++)
            {
                for (int j = 0; j < this.board.GetLength(1); j++)
                {
                    if (this.board[i, j] < other.board[i, j])
                    {
                        return -1;
                    }
                    else if (this.board[i, j] > other.board[i, j])
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }

        public override bool Equals(object obj)
        {
            QueensPositionsCombination other = (QueensPositionsCombination)obj;

            if (this.CompareTo(other) != 0)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
