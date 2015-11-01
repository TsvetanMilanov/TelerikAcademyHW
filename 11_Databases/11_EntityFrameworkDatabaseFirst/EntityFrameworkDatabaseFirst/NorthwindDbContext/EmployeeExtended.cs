namespace NorthwindDbContext
{
    using System.Linq;

    public partial class Employee
    {
        public Territory GetTerritory
        {
            get
            {
                return this.Territories.FirstOrDefault();
            }
        }
    }
}
