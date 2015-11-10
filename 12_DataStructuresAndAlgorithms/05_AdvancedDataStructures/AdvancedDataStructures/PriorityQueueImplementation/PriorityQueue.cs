namespace PriorityQueueImplementation
{
    using System;
    using System.Linq;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private const int InitialQueueSize = 8;
        private T[] values;

        public PriorityQueue()
        {
            this.values = new T[InitialQueueSize];
        }

        public int Count { get; private set; }

        public void Enqueue(T item)
        {
            if (this.Count == 0)
            {
                this.values[this.Count + 1] = item;
                this.Count = 2;
            }
            else
            {
                if (this.values.Length <= this.Count)
                {
                    this.ResizeArrayWithValues();
                }

                this.values[this.Count++] = item;
                MoveItemUp();
            }
        }

        private void MoveItemUp()
        {
            int position = this.Count - 1;

            while (position > 0 && this.values[position / 2].CompareTo(this.values[position]) < 0)
            {
                T y = this.values[position];
                this.values[position] = this.values[position / 2];
                this.values[position / 2] = y;
                position = position / 2;
            }
        }

        public T Dequeue()
        {
            T min = this.values[1];
            this.values[1] = this.values[this.Count - 1];

            this.values[this.Count - 1] = default(T);
            this.Count--;
            MoveItemDown(1);
            return min;
        }

        private void MoveItemDown(int k)
        {
            T a = this.values[k];
            int smallest = k;

            if (2 * k < this.Count && this.values[smallest].CompareTo(this.values[2 * k]) < 0)
            {
                smallest = 2 * k;
            }
            if (2 * k + 1 < this.Count && this.values[smallest].CompareTo(this.values[2 * k + 1]) < 0)
            {
                smallest = 2 * k + 1;
            }
            if (smallest != k)
            {
                Swap(k, smallest);
                MoveItemDown(smallest);
            }
        }

        private void Swap(int a, int b)
        {
            T temp = this.values[a];
            this.values[a] = this.values[b];
            this.values[b] = temp;
        }

        private void ResizeArrayWithValues()
        {
            var oldVaues = this.values.ToArray();

            int oldCapacity = this.values.Length;
            this.Count = 0;

            this.values = new T[oldCapacity * 2];

            foreach (var item in oldVaues)
            {
                if (item.CompareTo(default(T)) != 0)
                {
                    this.Enqueue(item);
                }
            }
        }
    }
}
