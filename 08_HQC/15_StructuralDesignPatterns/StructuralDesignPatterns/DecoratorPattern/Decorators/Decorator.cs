namespace DecoratorPattern.Decorators
{
    using DecoratorPattern.Components;

    public abstract class Decorator : Desk
    {
        public Decorator(Desk desk) : base(desk.Material, desk.Printer)
        {
            this.Desk = desk;
        }

        public Desk Desk { get; private set; }
    }
}
