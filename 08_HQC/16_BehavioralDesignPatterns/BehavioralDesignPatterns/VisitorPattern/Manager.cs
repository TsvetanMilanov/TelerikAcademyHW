namespace VisitorPattern
{
    public class Manager : IVisitor
    {
        public void Visit(Employee employee)
        {
            employee.Efficiency += 50;
        }
    }
}
