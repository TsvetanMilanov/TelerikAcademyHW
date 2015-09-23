namespace MediatorPattern
{
    public class Commander : ICommander
    {
        private const int MaxSoldiersToCommand = 20;

        public Commander(string name)
        {
            this.Name = name;
            this.Soldiers = new ISoldier[MaxSoldiersToCommand];
        }

        public string Name { get; set; }

        private ISoldier[] Soldiers { get; set; }

        public void AddSoldier(ISoldier soldier)
        {
            for (int i = 0; i < this.Soldiers.Length; i++)
            {
                if (this.Soldiers[i] == null)
                {
                    this.Soldiers[i] = soldier;
                    return;
                }
            }
        }

        public void OrderSoldiersInLine()
        {
            for (int i = 0; i < this.Soldiers.Length; i++)
            {
                ISoldier currentSoldier = this.Soldiers[i];

                if (currentSoldier == null)
                {
                    return;
                }

                currentSoldier.Position = i;
            }
        }
    }
}
