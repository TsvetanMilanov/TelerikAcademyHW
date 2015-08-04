namespace SortingAlgorithmsCompare
{
    using System;

    public class ArrayHolder<T>
    {
        public ArrayHolder(T[] randomArray, T[] sortedArray, T[] reversedSortedArray)
        {
            this.RandomArray = randomArray;
            this.SortedArray = sortedArray;
            this.ReversedSortedArray = reversedSortedArray;
        }

        public T[] RandomArray { get; set; }

        public T[] SortedArray { get; set; }

        public T[] ReversedSortedArray { get; set; }
    }
}
