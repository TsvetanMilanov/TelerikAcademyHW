namespace SortingAlgorithmsCompare
{
    using System;
    using System.Linq;

    public static class SortingAlgorithms
    {
        public static T[] InsertionSort<T>(T[] inputArray) where T : IComparable
        {
            T[] sortedCollection = inputArray.ToArray();

            for (int counter = 0; counter < sortedCollection.Length - 1; counter++)
            {
                int index = counter + 1;

                while (index > 0)
                {
                    T firstElement = sortedCollection[index - 1];
                    T secondElement = sortedCollection[index];

                    if (firstElement.CompareTo(secondElement) > 0)
                    {
                        sortedCollection = SwapValuesInArray(
                            sortedCollection,
                            firstElement,
                            secondElement,
                            index - 1,
                            index);
                    }

                    index--;
                }
            }

            return sortedCollection;
        }

        public static T[] SelectionSort<T>(T[] inputArray) where T : IComparable
        {
            T[] copiedArray = inputArray.ToArray();

            for (int i = 0; i < copiedArray.Length - 1; i++)
            {
                int minimumIndex = i;

                for (int k = i + 1; k < copiedArray.Length; k++)
                {
                    T currentElement = copiedArray[k];
                    T elementAtMinimumIndex = copiedArray[minimumIndex];
                    if (currentElement.CompareTo(elementAtMinimumIndex) < 0)
                    {
                        minimumIndex = k;
                    }
                }

                T firstElement = copiedArray[minimumIndex];
                T secondElement = copiedArray[i];

                copiedArray = SwapValuesInArray(
                    copiedArray,
                    firstElement,
                    secondElement,
                    minimumIndex,
                    i);
            }

            return copiedArray;
        }

        public static T[] QuickSort<T>(T[] inputArray) where T : IComparable
        {
            T[] coppiedArray = inputArray.ToArray();

            coppiedArray = PerformQuickSort(coppiedArray, 0, coppiedArray.Length - 1);

            return coppiedArray;
        }

        private static T[] PerformQuickSort<T>(T[] inputArray, int leftIndex, int rightIndex)
            where T : IComparable
        {
            T[] clonedArray = inputArray.ToArray();

            int i = leftIndex, j = rightIndex;
            T pivot = clonedArray[(leftIndex + rightIndex) / 2];

            while (i <= j)
            {
                while (clonedArray[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (clonedArray[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    T firstElement = clonedArray[i];
                    T secondELement = clonedArray[j];

                    clonedArray = SwapValuesInArray(clonedArray, firstElement, secondELement, i, j);

                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                clonedArray = PerformQuickSort(clonedArray, leftIndex, j);
            }

            if (i < rightIndex)
            {
                clonedArray = PerformQuickSort(clonedArray, i, rightIndex);
            }

            return clonedArray;
        }

        private static T[] SwapValuesInArray<T>(
            T[] array, T firstElement, T secondElement, int firstElementIndex, int secondElementIndex)
        {
            T[] copiedArray = array.ToArray();

            T storedFirstElement = firstElement;
            copiedArray[firstElementIndex] = secondElement;
            copiedArray[secondElementIndex] = storedFirstElement;

            return copiedArray;
        }
    }
}
