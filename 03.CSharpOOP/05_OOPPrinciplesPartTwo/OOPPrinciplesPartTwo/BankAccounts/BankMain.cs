namespace Bank.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Bank.Accounts;
    using Bank.Customers;

    public class BankAccountsMain
    {
        public static void Main()
        {
            Deposit deposit = new Deposit(new Individual("Gosho", "Goshov", "Goshov"), 10M);

            deposit.DepositSum(2000);
            deposit.DrawSum(1000);

            Console.WriteLine(deposit.Customer.DisplayCustomersName());
            Console.WriteLine("Interest amount for the deposit: {0:C2}\n", deposit.CalculateInterestForPeriod(2));

            Loan loan = new Loan(new Individual("Pesho", "Peshov", "Peshov"), 100, 10M);

            Console.WriteLine(loan.Customer.DisplayCustomersName());
            Console.WriteLine("Interest amount for the loan: {0:C2}\n", loan.CalculateInterestForPeriod(5));

            Mortgage mortgage = new Mortgage(new Company("SAP"), 100, 10M);

            Console.WriteLine(mortgage.Customer.DisplayCustomersName());
            Console.WriteLine("Interest amount for the mortgage: {0:C2}\n", mortgage.CalculateInterestForPeriod(4));
        }
    }
}
