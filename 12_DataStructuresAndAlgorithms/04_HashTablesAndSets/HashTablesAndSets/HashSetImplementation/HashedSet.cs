namespace HashSetImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using HashTableImplementation;

    public class HashedSet<T> : IEnumerable<T> where T : IComparable<T>
    {
        private HashTable<int, T> values;

        public HashedSet()
        {
            this.values = new HashTable<int, T>();
        }

        public int Count { get { return this.values.Count; } }

        public void Add(T entity)
        {
            int hash = entity.GetHashCode();

            if (this.values.Keys.Contains(hash))
            {
                return;
            }

            this.values.Add(hash, entity);
        }

        public void Remove(T entity)
        {
            int hash = entity.GetHashCode();
            this.values.Remove(hash);
        }

        public T Find(T entity)
        {
            int hash = entity.GetHashCode();

            return this.values.Find(hash);
        }

        public void Clear()
        {
            this.values.Clear();
        }

        public static HashedSet<T> Union(HashedSet<T> firstSet, HashedSet<T> secondSet)
        {
            HashedSet<T> result = new HashedSet<T>();
            foreach (var item in firstSet)
            {
                result.Add(item);
            }

            foreach (var item in secondSet)
            {
                result.Add(item);
            }

            return result;
        }

        public static HashedSet<T> Intersect(HashedSet<T> firstSet, HashedSet<T> secondSet)
        {
            var result = new HashedSet<T>();

            if (firstSet.Count > secondSet.Count)
            {
                result = AddRepeatableItems(firstSet, secondSet);
            }
            else
            {
                result = AddRepeatableItems(secondSet, firstSet);
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var pair in this.values)
            {
                yield return pair.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private static HashedSet<T> AddRepeatableItems(HashedSet<T> biggerSet, HashedSet<T> smallerSet)
        {
            var result = new HashedSet<T>();

            foreach (var item in smallerSet)
            {
                var foundItem = biggerSet.Find(item);

                if (foundItem.CompareTo(default(T)) != 0)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
