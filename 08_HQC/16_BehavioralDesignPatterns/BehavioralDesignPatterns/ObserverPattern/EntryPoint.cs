namespace ObserverPattern
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            DirtyLawEnforcementAgent financeInspector = new FinanceInspector("Pesho");

            Criminal artThief = new Thief("Gosho");
            Criminal moneyLaunderer = new MoneyLaunderer("Ivan");

            financeInspector.ReceiveBride(artThief);
            financeInspector.ReceiveBride(moneyLaunderer);

            Console.WriteLine("Status before the start of the investigation:");
            Console.WriteLine(artThief.Status);
            Console.WriteLine(moneyLaunderer.Status);

            financeInspector.StartInvestigation("Art scam");

            Console.WriteLine();
            Console.WriteLine("Status after the start of the investigation:");
            Console.WriteLine(artThief.Status);
            Console.WriteLine(moneyLaunderer.Status);
        }
    }
}
