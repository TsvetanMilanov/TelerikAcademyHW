namespace NorthwindDbContext
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            var context = new NorthwindEntities();
            var customer = new Customer
            {
                CustomerID = "ZSCID",
                CompanyName = "Some company name",
                ContactName = "Some contact name",
                ContactTitle = "Some contact title",
                Address = "some address",
                City = "Some city",
                Region = "Some region",
                PostalCode = "1234",
                Country = "Some country",
                Phone = "0888-888-888",
                Fax = "0888-888-888"
            };

            using (context)
            {
                Homework.TestDaoClass(context, customer);
                Homework.FilterOrdersByYearAndDestination(context);
                Homework.FilterSalesByRegionAndperiod(context);
                Homework.ConcurencySolution(context);
                Homework.TestExtendedEmployeeClass(context);
            }
        }
    }
}
