namespace DecoratorPattern.Components
{
    public class MetalDesk : Desk
    {
        public MetalDesk(IPrinter printer) : base("Metal", printer)
        {
        }

        public override void Display()
        {
            base.Display();
            this.Printer.Print("Clean with", "Wood cleaner");
        }
    }
}
