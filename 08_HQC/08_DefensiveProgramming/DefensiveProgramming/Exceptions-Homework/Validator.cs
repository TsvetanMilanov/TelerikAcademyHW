namespace Exceptions
{
    using System;
    using System.Collections.Generic;

    public static class Validator
    {
        public static void CheckIfNull<T>(T value, string propertyName)
        {
            string errorMessage = string.Format("{0} must not be null!", propertyName);

            if (value == null)
            {
                throw new ArgumentNullException(errorMessage);
            }
        }

        public static void CheckIfCollectionIsEmpty<T>(ICollection<T> collection, string collectionName)
        {
            string errorMessage = string.Format("{0} must not be empty!", collectionName);

            if (collection.Count <= 0)
            {
                throw new ArgumentException(errorMessage);
            }
        }

        public static void CheckIfStringIsValid(string value, string propertyName)
        {
            string errorMessageStringEmpty = string.Format("{0} must not be empty!", propertyName);
            string errorMessageNullOrWhiteSpace = string.Format("{0} must not be white space or null!", propertyName);

            if (value.Length <= 0)
            {
                throw new ArgumentException(errorMessageStringEmpty);
            }

            if (string.IsNullOrWhiteSpace(value) == true)
            {
                throw new ArgumentException(errorMessageNullOrWhiteSpace);
            }
        }

        public static void CheckIfStringLengthIsInRange(
                                                        string value,
                                                        int minRange,
                                                        int maxRange,
                                                        string propertyName)
        {
            int stringLength = value.Length;
            string errorMessage = string.Format(
                "{0}'s length must be between {1} and {2} symbols long!",
                propertyName,
                minRange,
                maxRange);

            if (stringLength < minRange || maxRange < stringLength)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        public static void CheckIfCountIsBiggerThanStringLength(
                                                                int count,
                                                                string stringValue,
                                                                string propertyName)
        {
            int stringLength = stringValue.Length;
            string errorMessage = string.Format("{0} must be lesser than {1}", propertyName, stringLength);

            if (count > stringLength)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        public static void CheckIfNegativeNumber<T>(T number, string propertyName) where T : IComparable
        {
            string errorMessage = string.Format("{0} must not be negative number!", propertyName);

            if (number.CompareTo(0) < 0)
            {
                throw new ArgumentException(errorMessage);
            }
        }

        public static void CheckIfValueIsInRange<T>(T value, T minValue, T maxValue, string propertyName)
            where T : IComparable
        {
            string errorMessage = string.Format(
                                                "{0} must be between {1} and {2}",
                                                propertyName,
                                                minValue,
                                                maxValue);
            bool isLesserThanOrEqualToMaxValue = value.CompareTo(maxValue) <= 0;
            bool isGreaterThanOrEqualToMinValue = value.CompareTo(minValue) >= 0;

            if (!isLesserThanOrEqualToMaxValue || !isGreaterThanOrEqualToMinValue)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        public static void CheckIfMaxValueIsBiggerThanMinValue<T>(
                                                                  T minValue,
                                                                  T maxValue,
                                                                  string minValuePropertyName,
                                                                  string maxValuePropertyName)
                                                                  where T : IComparable
        {
            string errorMessage = string.Format(
                "{0} must be less than {1}",
                minValuePropertyName,
                maxValuePropertyName);

            if (minValue.CompareTo(maxValue) >= 0)
            {
                throw new ArgumentException(errorMessage);
            }
        }
    }
}