namespace BiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BiDictionary<TKey1, TKey2, TValue>
    {
        private Dictionary<TKey1, List<TValue>> firstKeyValues;
        private Dictionary<TKey2, List<TValue>> secondKeyValues;

        public BiDictionary()
        {
            this.firstKeyValues = new Dictionary<TKey1, List<TValue>>();
            this.secondKeyValues = new Dictionary<TKey2, List<TValue>>();
        }

        public void Add(TKey1 key1, TKey2 key2, TValue value)
        {
            this.Add(key1, value);
            this.Add(key2, value);
        }

        public void Add(TKey1 key, TValue value)
        {
            if (!this.firstKeyValues.ContainsKey(key))
            {
                this.firstKeyValues[key] = new List<TValue>();
            }

            this.firstKeyValues[key].Add(value);
        }

        public void Add(TKey2 key, TValue value)
        {
            if (!this.secondKeyValues.ContainsKey(key))
            {
                this.secondKeyValues[key] = new List<TValue>();
            }

            this.secondKeyValues[key].Add(value);
        }

        public List<TValue> Find(TKey1 key)
        {
            if (!this.firstKeyValues.ContainsKey(key))
            {
                throw new KeyNotFoundException();
            }

            return this.firstKeyValues[key];
        }

        public List<TValue> Find(TKey2 key)
        {
            if (!this.secondKeyValues.ContainsKey(key))
            {
                throw new KeyNotFoundException();
            }

            return this.secondKeyValues[key];
        }

        public List<TValue> Find(TKey1 key1, TKey2 key2)
        {
            var firstResults = this.Find(key1);
            var secondResults = this.Find(key2);

            return firstResults.Union(secondResults).ToList();
        }
    }
}
