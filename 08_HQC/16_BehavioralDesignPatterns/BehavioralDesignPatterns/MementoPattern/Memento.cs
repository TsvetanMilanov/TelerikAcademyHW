namespace MementoPattern
{
    public class Memento
    {
        public Memento(int money, bool isAlive, string location)
        {
            this.Money = money;
            this.IsAlive = isAlive;
            this.Location = location;
        }

        public int Money { get; set; }

        public bool IsAlive { get; set; }

        public string Location { get; set; }
    }
}
