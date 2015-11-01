namespace StackImplementation
{
    using System;
    using System.Linq;

    public class CustomStack<T>
    {
        private const int InitialStackSize = 4;

        private T[] stack;
        private int topItemIndex;

        public CustomStack()
        {
            this.stack = new T[InitialStackSize];
            this.topItemIndex = 0;
        }

        public int Count
        {
            get
            {
                return this.topItemIndex;
            }
        }

        public void Push(T item)
        {
            int stackLength = this.stack.Length;

            if (this.topItemIndex >= stackLength)
            {
                int newStackLength = stackLength * 2;
                T[] oldStackItems = this.stack.ToArray();

                this.stack = new T[newStackLength];
                Array.Copy(oldStackItems, this.stack, oldStackItems.Length);
            }

            this.stack[this.topItemIndex] = item;
            this.topItemIndex++;
        }

        public T Pop()
        {
            if (this.topItemIndex == 0)
            {
                return default(T);
            }

            T itemToPop = this.stack[--this.topItemIndex];

            return itemToPop;
        }
    }
}
