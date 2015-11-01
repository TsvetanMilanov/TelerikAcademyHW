namespace LinkedListTask
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var firstListItem = new ListItem<int>() { Value = 1 };
            var secondListItem = new ListItem<int>() { Value = 2 };
            var thirdListItem = new ListItem<int>() { Value = 3 };
            var fourthListItem = new ListItem<int>() { Value = 4 };
            var fifthListItem = new ListItem<int>() { Value = 5 };

            firstListItem.NextItem = secondListItem;
            secondListItem.NextItem = thirdListItem;
            thirdListItem.NextItem = fourthListItem;
            fourthListItem.NextItem = fifthListItem;
            fifthListItem.NextItem = null;

            var linkedList = new LinkedList<int>() { FirstElement = firstListItem };

            Console.WriteLine("The elements in the linked list are:");
            while (linkedList.FirstElement != null)
            {
                Console.WriteLine("{0} ", linkedList.FirstElement.Value);
                linkedList.FirstElement = linkedList.FirstElement.NextItem;
            }
        }
    }
}