namespace QueueImplementation
{
    public class LinkedQueueItem<T>
    {
        public T Value { get; set; }

        public LinkedQueueItem<T> Next { get; set; }

        public override string ToString()
        {
            return string.Format("Value={0} Next={1}", this.Value, this.Next.Value);
        }
    }
}
