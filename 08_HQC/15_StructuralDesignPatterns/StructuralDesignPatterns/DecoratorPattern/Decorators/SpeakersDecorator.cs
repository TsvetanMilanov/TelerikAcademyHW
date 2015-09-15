namespace DecoratorPattern.Decorators
{
    using DecoratorPattern.Components;

    public class SpeakersDecorator : Decorator
    {
        private string media;

        public SpeakersDecorator(Desk desk) : base(desk)
        {
        }

        public void AddMedia(string media)
        {
            this.media = media;
        }

        public override void Display()
        {
            this.Desk.Display();
            this.Desk.Printer.Print("Now playing", this.media);
        }
    }
}
