namespace GSMInformation.Tests
{
    using System;

    using GSMInformation.Components;
    using GSMInformation.Enumerations;

    public class GSMTest
    {
        public static void Main()
        {
            GSM[] gsmArray = new GSM[3];

            gsmArray[0] = new GSM("X10", "Sony Ericsson", 600, "Ceco", new Battery("BST-41", 425, 8, BatteryType.LiIon), new Display(4.0f, 16000000));
            gsmArray[1] = new GSM("M2", "Sony", 800, "Pesho", new Battery("BST-127", 625, 12, BatteryType.LiPolymer), new Display(5.0f, 16000000));
            gsmArray[2] = new GSM("Z3", "Sony", 1000, "Gosho", new Battery("BST-300", 825, 24, BatteryType.LiIon), new Display(6.0f, 16000000));

            foreach (var gsm in gsmArray)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine();

            ///Test GSMCallHistoryTest.
            Console.Write("Test the call hystory class? [yes/no]: ");
            if (Console.ReadLine() == "yes")
            {
                Console.Clear();

                GSMCallHistoryTest.TestCallHistory();
            }
        }
    }
}
