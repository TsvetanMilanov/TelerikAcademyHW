namespace NorthwindDbContext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Homework
    {
        public static void TestDaoClass(NorthwindEntities context, Customer customer)
        {
            NorthwindDao.AddCustomer(context, customer);
            Customer addedCustomer = NorthwindDao.FindCustomerById(context, customer.CustomerID);

            Console.WriteLine("Added customer:");

            PrintCustomerInformation(addedCustomer);

            customer.ContactTitle = "UPDATED TITLE";

            NorthwindDao.EditCustomer(context, customer);
            Customer updatedCustomer = NorthwindDao.FindCustomerById(context, customer.CustomerID);

            Console.WriteLine("Updated customer:");

            PrintCustomerInformation(updatedCustomer);

            NorthwindDao.DeleteCustomer(context, customer);
            Customer deletedCustomer = NorthwindDao.FindCustomerById(context, customer.CustomerID);

            Console.WriteLine("Deleted customer:");

            PrintCustomerInformation(deletedCustomer);
        }

        public static void FilterOrdersByYearAndDestination(NorthwindEntities context)
        {
            IEnumerable<Customer> filteredCustomers =
                    NorthwindDao.FindCustomersWithSpecialOrders(context, 1997, "Canada");

            Console.WriteLine("\n*************************************************************\n");
            Console.WriteLine("Customers with orders made in 1997 and shipped to Canada:");
            foreach (var currentCustomer in filteredCustomers)
            {
                PrintCustomerInformation(currentCustomer);
            }

            Console.WriteLine("\n*************************************************************\n");
        }

        public static void FilterOrdersByYearAndDestinationWithSqlQuery(NorthwindEntities context)
        {
            IEnumerable<Customer> filteredCustomersByQuery =
                    NorthwindDao.FindCustomersWithSpecialOrdersWithSqlQuery(context, 1997, "Canada");

            Console.WriteLine("\n*************************************************************\n");
            Console.WriteLine("Customers with orders made in 1997 and shipped to Canada With SQL:");
            foreach (var currentCustomer in filteredCustomersByQuery)
            {
                PrintCustomerInformation(currentCustomer);
            }
        }

        public static void FilterSalesByRegionAndperiod(NorthwindEntities context)
        {
            Console.WriteLine("\n*************************************************************\n");
            Console.WriteLine("Sales by region and period:");
            DateTime startDate = new DateTime(1998, 1, 1, 0, 0, 0);
            DateTime endDate = DateTime.Now;
            IEnumerable<Order> filteredSales = NorthwindDao.FindSalesByRegionInPerion(context, "RJ", startDate, endDate);
            foreach (var order in filteredSales)
            {
                PrintOrderInformation(order);
            }

            Console.WriteLine("\n*************************************************************\n");
        }

        public static void ConcurencySolution(NorthwindEntities context)
        {
            var secondContext = new NorthwindEntities();

            using (secondContext)
            {
                context.Configuration.EnsureTransactionsForFunctionsAndCommands = true;
                secondContext.Configuration.EnsureTransactionsForFunctionsAndCommands = true;

                context.Employees.First().Country = "Edited country";
                secondContext.Employees.First().Country = "Second edit";
            }
        }

        public static void TestExtendedEmployeeClass(NorthwindEntities context)
        {
            var employee = context.Employees.FirstOrDefault();

            var teritory = employee.GetTerritory;

            Console.WriteLine("TerritoryID: {0}\nTerritory description: {1}", teritory.TerritoryID, teritory.TerritoryDescription);
        }

        private static void PrintCustomerInformation(Customer customer)
        {
            if (customer != null)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(
                    "CustomerID: {0}\nCompany name: {1}\nContact title: {2}\nCity: {3}",
                    customer.CustomerID,
                    customer.CompanyName,
                    customer.ContactTitle,
                    customer.City);
                Console.WriteLine("---------------");
            }
            else
            {
                Console.WriteLine("No customer was found!");
            }
        }

        private static void PrintOrderInformation(Order order)
        {
            Console.WriteLine("-------");
            Console.WriteLine(
                "OrderID: {0}\nShippedDate: {1}\nShipRegion: {2}\nShipCountry: {3}",
                order.OrderID,
                order.ShippedDate,
                order.ShipRegion,
                order.ShipCountry);
            Console.WriteLine("-------");
        }
    }
}
