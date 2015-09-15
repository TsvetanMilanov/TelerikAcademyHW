namespace DecoratorPattern.Components
{
    public abstract class Desk
    {
        public Desk(string material, IPrinter printer)
        {
            this.Material = material;
            this.Printer = printer;
        }

        public string Material { get; set; }

        public IPrinter Printer { get; set; }

        public virtual void Display()
        {
            this.Printer.Print("Material", this.Material);
        }
    }
}
