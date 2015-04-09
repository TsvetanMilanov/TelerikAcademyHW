namespace GenericClass
{
    using System;
    using System.Text;

    public class GenericList<T> where T : struct, IComparable
    {
        private const int DefaultArraySize = 8;
        private const int StartIndex = 0;

        private T[] list;

        private int currentIndex;

        private int capacity;

        public GenericList(int capacity)
        {
            this.CurrentIndex = StartIndex;
            this.Capacity = capacity;
            this.List = new T[this.Capacity];
        }

        public int CurrentIndex
        {
            get
            {
                return this.currentIndex;
            }

            private set
            {
                this.currentIndex = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                this.capacity = value;
            }
        }

        public int Size
        {
            get
            {
                int size = 0;

                size = this.CurrentIndex;

                return size;
            }
        }

        private T[] List
        {
            get
            {
                return this.list;
            }

            set
            {
                this.list = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.CurrentIndex || index < 0)
                {
                    throw new IndexOutOfRangeException("The index is out of the range of the collection.");
                }

                return this.List[index];
            }

            set
            {
                while (this.CurrentIndex >= this.Capacity)
                {
                    this.Capacity = this.Capacity * 2;

                    var oldList = this.List;

                    this.list = new T[this.Capacity];

                    Array.Copy(oldList, this.List, this.CurrentIndex);
                }

                this.List[index] = value;

                this.CurrentIndex++;
            }
        }

        public void AddItem(T item)
        {
            while (this.CurrentIndex >= this.Capacity)
            {
                this.Capacity = this.Capacity * 2;

                var oldList = this.List;

                this.List = new T[this.Capacity];

                Array.Copy(oldList, this.List, this.CurrentIndex);
            }

            this.List[this.CurrentIndex] = item;

            this.CurrentIndex++;
        }

        public void RemoveAtIndex(int index)
        {
            T[] firstHalf = new T[index];

            Array.Copy(this.List, firstHalf, index);

            T[] secondHalf = new T[this.Size - index - 1];

            Array.Copy(this.List, firstHalf.Length + 1, secondHalf, 0, secondHalf.Length);

            this.List = new T[firstHalf.Length + secondHalf.Length];

            Array.Copy(firstHalf, 0, this.List, 0, firstHalf.Length);
            Array.Copy(secondHalf, 0, this.List, firstHalf.Length, secondHalf.Length);

            this.CurrentIndex--;
        }

        public void InsertAtIndex(int index, T element)
        {
            if (index >= this.CurrentIndex || index < 0)
            {
                throw new IndexOutOfRangeException("The index is out of the range of the collection.");
            }

            this.CurrentIndex++;

            if (this.CurrentIndex >= this.Capacity)
            {
                this.Capacity = this.Capacity * 2;

                var oldList = this.List;

                this.List = new T[this.Capacity];

                Array.Copy(oldList, this.List, this.CurrentIndex - 1);
            }

            T[] firstHalf = new T[index + 1];

            Array.Copy(this.List, firstHalf, index);

            firstHalf[firstHalf.Length - 1] = element;

            T[] secondHalf = new T[this.Size - index];

            Array.Copy(this.List, firstHalf.Length - 1, secondHalf, 0, secondHalf.Length);

            this.List = new T[firstHalf.Length + secondHalf.Length];

            Array.Copy(firstHalf, 0, this.List, 0, firstHalf.Length);
            Array.Copy(secondHalf, 0, this.List, firstHalf.Length, secondHalf.Length);
        }

        public void ClearList()
        {
            this.CurrentIndex = StartIndex;
            this.Capacity = DefaultArraySize;
            this.List = new T[this.Capacity];
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.CurrentIndex; i++)
            {
                result.Append(string.Format("{0}\n", this[i]));
            }

            return result.ToString().TrimEnd();
        }

        public int FindElement(T element)
        {
            int index = -1;

            for (int i = 0; i < this.CurrentIndex; i++)
            {
                T currentElement = this[i];

                if (currentElement.CompareTo(element) == 0)
                {
                    index = i;
                }
            }

            return index;
        }

        public T Min()
        {
            T min = this.List[0];

            foreach (var item in this.List)
            {
                if (min.CompareTo(item) >= 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.List[0];

            foreach (var item in this.List)
            {
                if (max.CompareTo(item) <= 0)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}
