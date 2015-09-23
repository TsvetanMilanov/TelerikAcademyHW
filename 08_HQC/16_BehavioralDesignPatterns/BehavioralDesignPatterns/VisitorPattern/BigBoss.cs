namespace VisitorPattern
{
    public class BigBoss : IVisitor
    {
        public void Visit(Employee employee)
        {
            employee.Efficiency += 500;
        }
    }
}
