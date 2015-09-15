namespace DecoratorPattern.Components
{
    public class PlasticDesk : Desk
    {
        public PlasticDesk(IPrinter printer) : base("Wood", printer)
        {
        }

        public override void Display()
        {
            base.Display();
            this.Printer.Print("Clean with", "Metal cleaner");
        }
    }
}
