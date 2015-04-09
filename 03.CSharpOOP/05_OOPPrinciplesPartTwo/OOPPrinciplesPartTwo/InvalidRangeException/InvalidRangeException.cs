namespace InvalidRange
{
    using System;

    public class InvalidRangeException<T> : Exception
    {
        public InvalidRangeException(T inputStart, T inputEnd, string inputMessage)
        {
            this.Start = inputStart;
            this.End = inputEnd;
            this.Message = inputMessage;
        }

        public string Message { get; private set; }

        public T Start { get; private set; }

        public T End { get; private set; }
    }
}
