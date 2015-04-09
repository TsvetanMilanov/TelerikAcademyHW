namespace Bank.Accounts
{
    using System;

    using Bank.Customers;

    public class Loan : Account, IDepositable
    {
        public Loan(Customer inputCustomer, decimal inputBalance, decimal inputInterestRate)
            : base(inputCustomer, inputInterestRate)
        {
            this.Balance = inputBalance;
        }

        /// <summary>
        /// Returns string with the balance of the account.
        /// </summary>
        public string GetBalance
        {
            get
            {
                return string.Format("{0}", -this.Balance);
            }
        }

        /// <summary>
        /// Deposit given sum.
        /// </summary>
        public void DepositSum(decimal amount)
        {
            if (this.Balance < amount)
            {
                throw new InvalidOperationException("The amount of the deposit is greater the amount needed.");
            }

            this.Balance = this.Balance - amount;
        }

        public override decimal CalculateInterestForPeriod(decimal months)
        {
            if (this.Customer is Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else if (months > 3)
                {
                    months = months - 3;
                }
            }
            else if (this.Customer is Company)
            {
                if (months <= 2)
                {
                    return 0;
                }
                else if (months > 2)
                {
                    months = months - 2;
                }
            }

            return base.CalculateInterestForPeriod(months);
        }
    }
}
