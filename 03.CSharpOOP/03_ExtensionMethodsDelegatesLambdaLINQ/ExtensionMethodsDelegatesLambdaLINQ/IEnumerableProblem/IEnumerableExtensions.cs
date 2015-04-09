namespace IEnumerableProblem
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : struct
        {
            T firstItem = GetFirstGenericItem<T>(collection);
            T sum = firstItem;

            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            return sum - (dynamic)firstItem;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : struct
        {
            T firstItem = GetFirstGenericItem<T>(collection);
            T sum = firstItem;

            foreach (var item in collection)
            {
                sum *= (dynamic)item;
            }

            if ((dynamic)firstItem == 0)
            {
                sum = (dynamic)0;
                return sum;
            }

            return sum / (dynamic)firstItem;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : struct, IComparable<T>
        {
            T firstItem = GetFirstGenericItem<T>(collection);
            T min = firstItem;

            foreach (var item in collection)
            {
                if (min.CompareTo(item) >= 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : struct, IComparable<T>
        {
            T firstItem = GetFirstGenericItem<T>(collection);
            T max = firstItem;

            foreach (var item in collection)
            {
                if (max.CompareTo(item) <= 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : struct
        {
            T firstItem = GetFirstGenericItem<T>(collection);
            T sum = firstItem;
            int count = 0;

            foreach (var item in collection)
            {
                count++;
                sum += (dynamic)item;
            }

            T average = (sum - (dynamic)firstItem) / count;
            return average;
        }

        private static K GetFirstGenericItem<K>(IEnumerable<K> collection)
        {
            K firstItem;

            bool isFirstElement = true;

            foreach (var item in collection)
            {
                if (isFirstElement)
                {
                    firstItem = item;
                    return firstItem;
                }
            }

            throw new ArgumentException("The collection is invalid.");
        }
    }
}
