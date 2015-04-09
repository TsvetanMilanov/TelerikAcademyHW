namespace GenericClass
{
    using System;

    public class GenericsTest
    {
        public static void Main()
        {
            /// Test the generic list.

            GenericList<int> testList = new GenericList<int>(8);

            testList[0] = 0;
            testList[1] = 1;
            testList[2] = 2;
            testList[3] = 3;
            testList.AddItem(4);
            testList.AddItem(5);
            testList.AddItem(6);
            testList.AddItem(7);

            Console.WriteLine("The element at 7th position is: {0}\n", testList[7]);

            testList.RemoveAtIndex(2);

            Console.WriteLine("The collection without the removed element at index 2 is:");
            Console.WriteLine(testList.ToString());

            testList.InsertAtIndex(2, 2);

            Console.WriteLine("The collection with the inserted element 2 at index 2 is:");
            Console.WriteLine(testList.ToString());

            int indexOfElement = testList.FindElement(7);

            Console.WriteLine("\nThe index of element 7 is: {0}\n", indexOfElement);

            int min = testList.Min();
            Console.WriteLine("The minimal element in the collection is: {0}\n", min);

            int max = testList.Max();
            Console.WriteLine("The maximal element in the collection is: {0}\n", max);

            testList.ClearList();
            Console.WriteLine("The cleared collection is: [{0}]\n", testList.ToString());
        }
    }
}
