namespace ObserverPattern
{
    using System.Collections.Generic;

    public abstract class DirtyLawEnforcementAgent
    {
        public DirtyLawEnforcementAgent(string name)
        {
            this.Name = name;
            this.Criminals = new List<Criminal>();
        }

        public string Name { get; set; }

        public string Investigation { get; set; }

        private IList<Criminal> Criminals { get; set; }

        public void ReceiveBride(Criminal criminal)
        {
            this.Criminals.Add(criminal);
        }

        public void StartInvestigation(string investigation)
        {
            this.Investigation = investigation;

            this.WarnCriminals();
        }

        private void WarnCriminals()
        {
            foreach (var criminal in this.Criminals)
            {
                criminal.Notify(this);
            }
        }
    }
}
