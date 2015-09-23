namespace MediatorPattern
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            ICommander general = new Commander("Grand General");
            ISoldier goshoSoldier = new Soldier("Gosho");
            ISoldier peshoSoldier = new Marine("Pesho");
            ISoldier ivanSoldier = new Soldier("Ivan");

            general.AddSoldier(goshoSoldier);
            general.AddSoldier(peshoSoldier);
            general.AddSoldier(ivanSoldier);

            general.OrderSoldiersInLine();

            Console.WriteLine(goshoSoldier.Report());
            Console.WriteLine(peshoSoldier.Report());
            Console.WriteLine(ivanSoldier.Report());
        }
    }
}