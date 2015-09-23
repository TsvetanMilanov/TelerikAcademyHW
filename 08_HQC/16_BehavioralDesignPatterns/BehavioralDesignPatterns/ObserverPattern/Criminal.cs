namespace ObserverPattern
{
    public abstract class Criminal
    {
        public Criminal(string name, string hidingPlace)
        {
            this.Name = name;
            this.HidingPlace = hidingPlace;
            this.Status = string.Format("I am {0} and I am free.", this.Name);
        }

        public string Name { get; set; }

        public string HidingPlace { get; set; }

        public string Status { get; set; }

        public void Notify(DirtyLawEnforcementAgent dirtyLawEnforcementAgent)
        {
            this.Status = string.Format(
                "I am {0} and I am going to {1} because of investigation - {2}",
                this.Name,
                this.HidingPlace,
                dirtyLawEnforcementAgent.Investigation);
        }
    }
}