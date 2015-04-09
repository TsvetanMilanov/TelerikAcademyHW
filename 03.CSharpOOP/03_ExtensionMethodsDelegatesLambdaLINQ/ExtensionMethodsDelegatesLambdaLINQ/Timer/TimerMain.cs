namespace TimerProblem
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Timers;

    public class TimerMain
    {
        public static void Main(string[] args)
        {
            Timer timer = new Timer(15000);

            timer.Elapsed += new ElapsedEventHandler(PrintMessage);

            timer.Interval = 5000;

            timer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program... ");
            Console.ReadLine();
        }

        private static void PrintMessage(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The timer works!!!");
        }
    }
}
