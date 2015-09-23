namespace VisitorPattern
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(string name)
            : base(name)
        {
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
