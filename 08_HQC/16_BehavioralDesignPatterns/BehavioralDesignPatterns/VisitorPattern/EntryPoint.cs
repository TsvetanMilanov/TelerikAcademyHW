namespace VisitorPattern
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            IVisitor bigBoss = new BigBoss();
            IVisitor manager = new Manager();

            Employee peshoEmployee = new RegularEmployee("Pesho");
            Employee goshoEmployee = new RegularEmployee("Gosho");

            Console.WriteLine("Efficiency before visits:");
            Console.WriteLine(peshoEmployee.Report());
            Console.WriteLine(goshoEmployee.Report());

            peshoEmployee.AcceptVisitor(manager);
            goshoEmployee.AcceptVisitor(bigBoss);

            Console.WriteLine();
            Console.WriteLine("Efficiency after visits:");
            Console.WriteLine(peshoEmployee.Report());
            Console.WriteLine(goshoEmployee.Report());
        }
    }
}
