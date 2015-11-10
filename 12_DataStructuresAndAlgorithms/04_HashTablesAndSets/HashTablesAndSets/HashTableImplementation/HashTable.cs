namespace HashTableImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>> where K : IComparable
    {
        private const int InitialCapacity = 16;
        private LinkedList<KeyValuePair<K, T>>[] values;
        private int capacity;
        private int keysCount;
        private IList<K> keys;

        public HashTable()
        {
            this.keysCount = 0;
            this.capacity = InitialCapacity;
            this.values = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.keys = new List<K>();
        }

        public int Count { get; private set; }

        public void Add(K key, T value)
        {
            if (this.keysCount > this.capacity * 0.75)
            {
                this.ResizeTable();
            }

            int index = this.CalculateIndexByKey(key);

            if (this.values[index] == null)
            {
                this.values[index] = new LinkedList<KeyValuePair<K, T>>();
                this.keysCount += 1;
            }

            if (!this.keys.Contains(key))
            {
                this.keys.Add(key);
            }

            this.values[index].AddLast(new KeyValuePair<K, T>(key, value));
            this.Count += 1;
        }

        public void Remove(K key)
        {
            int index = this.CalculateIndexByKey(key);

            var currentList = this.values[index];

            if (currentList != null)
            {
                var itemToRemove = currentList.First(p => p.Key.CompareTo(key) == 0);

                currentList.Remove(itemToRemove);

                this.Count -= 1;
            }
        }

        public T Find(K key)
        {
            int index = this.CalculateIndexByKey(key);

            if (this.values[index] == null)
            {
                return default(T);
            }

            var list = this.values[index];

            var item = list.FirstOrDefault(p => p.Key.CompareTo(key) == 0);

            return item.Value;
        }

        private void ResizeTable()
        {
            this.capacity *= 2;
            this.Count = 0;
            this.keysCount = 0;

            var oldValues = new LinkedList<KeyValuePair<K, T>>[this.values.Length];

            for (int i = 0; i < this.values.Length; i++)
            {
                oldValues[i] = new LinkedList<KeyValuePair<K, T>>();
                var currentList = this.values[i];

                if (currentList != null)
                {
                    foreach (var item in currentList)
                    {
                        oldValues[i].AddLast(item);
                    }
                }
            }

            this.values = new LinkedList<KeyValuePair<K, T>>[this.capacity];

            foreach (var value in oldValues)
            {
                if (value != null)
                {
                    foreach (var item in value)
                    {
                        this.Add(item.Key, item.Value);
                    }
                }
            }
        }

        private int CalculateIndexByKey(K key)
        {
            int hash = key.GetHashCode();

            int index = Math.Abs(hash % (this.capacity - 1));

            return index;
        }

        public T this[K key]
        {
            get
            {
                return this.Find(key);
            }
            set
            {
                int index = this.CalculateIndexByKey(key);

                var list = this.values[index];

                var item = list.FirstOrDefault(p => p.Key.CompareTo(key) == 0);
                list.Remove(item);
                item = new KeyValuePair<K, T>(key, value);
                list.AddLast(item);
            }
        }

        public IList<K> Keys
        {
            get
            {
                return this.keys.ToList();
            }

            private set
            {
                this.keys = value;
            }
        }

        public void Clear()
        {
            this.capacity = InitialCapacity;
            this.values = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.keys.Clear();
            this.keysCount = 0;
            this.Count = 0;
        }


        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var row in this.values)
            {
                if (row != null)
                {
                    foreach (var pair in row)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
