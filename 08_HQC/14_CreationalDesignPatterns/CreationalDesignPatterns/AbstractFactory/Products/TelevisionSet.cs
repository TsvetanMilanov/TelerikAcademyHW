namespace AbstractFactory.Products
{
    public class TelevisionSet
    {
        public TelevisionSet(int size)
        {
            this.Size = size;
        }

        public int Size { get; set; }

        public string GetInformation()
        {
            string information = "TV size: " + this.Size + " inches.";

            return information;
        }
    }
}
