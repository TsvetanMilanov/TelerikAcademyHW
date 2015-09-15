namespace DecoratorPattern.Decorators
{
    using DecoratorPattern.Components;

    public class LampDecorator : Decorator
    {
        public LampDecorator(Desk desk) : base(desk)
        {
            this.IsLightOn = true;
        }

        public bool IsLightOn { get; set; }

        public override void Display()
        {
            this.Desk.Display();
            this.Desk.Printer.Print("Light: ", this.IsLightOn == true ? "On" : "Off");
        }
    }
}
