namespace DecoratorPattern.Components
{
    public class WoodDesk : Desk
    {
        public WoodDesk(IPrinter printer) : base("Wood", printer)
        {
        }

        public override void Display()
        {
            base.Display();
            this.Printer.Print("Clean with", "Plastic cleaner");
        }
    }
}
