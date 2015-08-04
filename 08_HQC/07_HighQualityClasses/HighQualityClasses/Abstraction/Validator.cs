namespace Abstraction
{
    using System;

    public static class Validator
    {
        public static void CheckIfNumberIsPositive<T>(T number, string perimeterName) where T : struct, IComparable
        {
            if (number.CompareTo(0.0) <= 0)
            {
                throw new ArgumentOutOfRangeException(perimeterName + " must be greater than 0!");
            }
        }
    }
}
