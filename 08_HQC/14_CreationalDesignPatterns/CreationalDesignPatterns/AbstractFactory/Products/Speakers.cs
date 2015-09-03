namespace AbstractFactory.Products
{
    public class Speakers
    {
        public Speakers(bool isHifi)
        {
            this.IsHiFi = isHifi;
        }

        public bool IsHiFi { get; set; }

        public string GetInformation()
        {
            if (this.IsHiFi)
            {
                return "Speakers are HiFi!";
            }
            else
            {
                return "Speakers are not HiFi!";
            }
        }
    }
}
