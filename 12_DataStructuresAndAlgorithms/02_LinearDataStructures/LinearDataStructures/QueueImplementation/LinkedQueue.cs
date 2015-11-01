namespace QueueImplementation
{
    public class LinkedQueue<T>
    {
        public LinkedQueueItem<T> Head { get; private set; }

        public void Enqueue(T item)
        {
            if (this.Head == null)
            {
                this.Head = new LinkedQueueItem<T> { Value = item };
                return;
            }

            LinkedQueueItem<T> currentTail = this.Head;

            while (currentTail.Next != null)
            {
                currentTail = currentTail.Next;
            }

            currentTail.Next = new LinkedQueueItem<T> { Value = item, Next = null };
        }

        public T Dequeue()
        {
            T valueToReturn = this.Head.Value;
            this.Head = this.Head.Next;
            return valueToReturn;
        }
    }
}
