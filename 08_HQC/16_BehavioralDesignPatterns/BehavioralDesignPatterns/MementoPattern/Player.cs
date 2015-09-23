namespace MementoPattern
{
    public class Player : IPlayer
    {
        public Player(string name)
        {
            this.Name = name;
            this.Money = 0;
            this.IsAlive = true;
            this.Location = "Town";
        }

        public string Name { get; set; }

        public int Money { get; set; }

        public bool IsAlive { get; set; }

        public string Location { get; set; }

        public void RestoreMemento(Memento memento)
        {
            this.Money = memento.Money;
            this.IsAlive = memento.IsAlive;
            this.Location = memento.Location;
        }

        public Memento SaveMemento()
        {
            Memento memento = new Memento(this.Money, this.IsAlive, this.Location);

            return memento;
        }

        public string Introduce()
        {
            string introduction = string.Format(
                "I am {0}\nI have {1:C}\nI am {2}\nI am at {3}",
                this.Name,
                this.Money,
                this.IsAlive ? "Alive" : "Dead",
                this.Location);

            return introduction;
        }
    }
}
