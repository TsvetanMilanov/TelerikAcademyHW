namespace ArrayProblem
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        public ulong Number { get; set; }

        public string BinaryRepresentation
        {
            get
            {
                return this.ToString();
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this.BinaryRepresentation[i] - 48;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this.BinaryRepresentation[i] - 48;
            }
        }

        public override string ToString()
        {
            ulong currentNumber = this.Number;

            StringBuilder result = new StringBuilder();

            while (currentNumber != 0)
            {
                result.Insert(0, currentNumber % 2);
                currentNumber /= 2;
            }

            return result.ToString().PadLeft(64, '0');
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BitArray64 secondArray = obj as BitArray64;

            if (this.Number - secondArray.Number == 0)
            {
                return true;
            }

            return false;
        }

        public int this[int index]
        {
            get
            {
                return int.Parse(this.BinaryRepresentation[index].ToString());
            }
        }

        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
        {
            if (firstArray.Number - secondArray.Number == 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            if (firstArray.Number - secondArray.Number != 0)
            {
                return true;
            }

            return false;
        }
    }
}
