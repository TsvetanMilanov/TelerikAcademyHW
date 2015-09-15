namespace DecoratorPattern
{
    using System;

    using Components;
    using Decorators;

    public class EntryPoint
    {
        public static void Main()
        {
            IPrinter printer = new StandartPrinter();

            var woodDesk = new WoodDesk(printer);
            var metalDesk = new MetalDesk(printer);

            Console.WriteLine("----------- Ordinary desks:");
            woodDesk.Display();
            Console.WriteLine();
            metalDesk.Display();

            var woodDeskWithLamp = new LampDecorator(woodDesk);
            Console.WriteLine();
            Console.WriteLine("----------- Desk with lamp:");
            woodDeskWithLamp.Display();

            var woodDeskWithLampAndDrawer = new DrawerDecorator(woodDeskWithLamp);
            woodDeskWithLampAndDrawer.AddItemInDrawer("Paper");
            woodDeskWithLampAndDrawer.AddItemInDrawer("Triangle");
            woodDeskWithLampAndDrawer.AddItemInDrawer("Pen");
            woodDeskWithLampAndDrawer.AddItemInDrawer("Pen");
            woodDeskWithLampAndDrawer.AddItemInDrawer("Scissors");
            woodDeskWithLampAndDrawer.AddItemInDrawer("Bazooka");
            woodDeskWithLampAndDrawer.RemoveItemFromDrawer("Pen");

            Console.WriteLine();
            Console.WriteLine("----------- Desk with lamp and drawer:");
            woodDeskWithLampAndDrawer.Display();

            var woodDeskWithLampDrawerAndSpeakers =
                new SpeakersDecorator(woodDeskWithLampAndDrawer);

            woodDeskWithLampDrawerAndSpeakers.AddMedia("Some media by some artist");

            Console.WriteLine();
            Console.WriteLine("----------- Desk with lamp, drawer and speakers:");
            woodDeskWithLampDrawerAndSpeakers.Display();
        }
    }
}
