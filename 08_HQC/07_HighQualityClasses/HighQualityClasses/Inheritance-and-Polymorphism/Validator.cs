namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public static class Validator
    {
        public static void CheckListLength<T>(IList<T> list, string propertyName)
        {
            if (list == null || list.Count <= 0)
            {
                throw new ArgumentException(propertyName + " must contain at least one element!");
            }
        }

        public static void CheckStringLength(string value, int minLength, int maxLength, string propertyName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(propertyName + " must not be null!");
            }

            string lengthErrorMessage = string.Format(
                "{0} must be between {1} and {2} symbols long!",
                propertyName,
                minLength,
                maxLength);

            if (minLength > value.Length || value.Length > maxLength)
            {
                throw new ArgumentOutOfRangeException(lengthErrorMessage);
            }
        }
    }
}
