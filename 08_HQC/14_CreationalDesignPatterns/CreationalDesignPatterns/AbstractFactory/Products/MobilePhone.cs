namespace AbstractFactory.Products
{
    public class MobilePhone
    {
        public MobilePhone(string quality)
        {
            this.Quality = quality;
        }

        public string Quality { get; set; }

        public string GetInformation()
        {
            string information = "GSM quality: " + this.Quality;

            return information;
        }
    }
}
