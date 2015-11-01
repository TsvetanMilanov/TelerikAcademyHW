namespace NorthwindDbContext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class NorthwindDao
    {
        public static void AddCustomer(NorthwindEntities context, Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public static void DeleteCustomer(NorthwindEntities context, Customer customer)
        {
            var customerToDelete = context.Customers
                .Where(c => c.CustomerID == customer.CustomerID)
                .FirstOrDefault();

            context.Customers.Remove(customerToDelete);
            context.SaveChanges();
        }

        public static void EditCustomer(NorthwindEntities context, Customer customer)
        {
            var customerToUpdate = context.Customers
                .Where(c => c.CustomerID == customer.CustomerID)
                .FirstOrDefault();

            customerToUpdate.Address = customer.Address;
            customerToUpdate.City = customer.City;
            customerToUpdate.CompanyName = customer.CompanyName;
            customerToUpdate.ContactName = customer.ContactName;
            customerToUpdate.ContactTitle = customer.ContactTitle;
            customerToUpdate.Country = customer.Country;
            customerToUpdate.CustomerDemographics = customer.CustomerDemographics;
            customerToUpdate.Fax = customer.Fax;
            customerToUpdate.Orders = customer.Orders;
            customerToUpdate.Phone = customer.Phone;
            customerToUpdate.PostalCode = customer.PostalCode;
            customerToUpdate.Region = customer.Region;

            context.SaveChanges();
        }

        public static Customer FindCustomerById(NorthwindEntities context, string customerID)
        {
            var customer = context.Customers
                .Where(c => c.CustomerID == customerID)
                .FirstOrDefault();

            return customer;
        }

        public static IEnumerable<Customer> FindCustomersWithSpecialOrders(
            NorthwindEntities context,
            int yearOfOrder,
            string countryToShip)
        {
            IEnumerable<Customer> foundCustomers = context.Orders
                .Where(o => o.OrderDate.Value.Year == yearOfOrder && o.ShipCountry == countryToShip)
                .Select(o => o.Customer)
                .ToList();

            return foundCustomers;
        }

        public static IEnumerable<Customer> FindCustomersWithSpecialOrdersWithSqlQuery(
            NorthwindEntities context,
            int yearOfOrder,
            string countryToShip)
        {
            IEnumerable<Customer> foundCustomers = context.Customers.SqlQuery(
                @"SELECT *
                FROM Customers c
                    JOIN Orders o
                    ON o.CustomerID = c.CustomerID
                WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry LIKE 'Canada'");

            return foundCustomers;
        }

        public static IEnumerable<Order> FindSalesByRegionInPerion(
            NorthwindEntities context,
            string region,
            DateTime startDate,
            DateTime endDate)
        {
            IEnumerable<Order> foundSales = context.Orders
                .Where(o => o.ShipRegion == region &&
                    (o.ShippedDate.Value >= startDate && o.ShippedDate.Value <= endDate))
                .ToList();

            return foundSales;
        }
    }
}
