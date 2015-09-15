namespace DecoratorPattern.Decorators
{
    using System.Collections.Generic;

    using DecoratorPattern.Components;

    public class DrawerDecorator : Decorator
    {
        private IList<string> items;

        public DrawerDecorator(Desk desk) : base(desk)
        {
            this.items = new List<string>();
        }

        public void AddItemInDrawer(string item)
        {
            this.items.Add(item);
        }

        public void RemoveItemFromDrawer(string item)
        {
            this.items.Remove(item);
        }

        public override void Display()
        {
            this.Desk.Display();
            this.Desk.Printer.Print("Desk items", ":");

            foreach (var item in this.items)
            {
                this.Desk.Printer.Print("\tItem", item);
            }
        }
    }
}
