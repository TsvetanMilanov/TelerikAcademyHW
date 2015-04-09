namespace Bank.Accounts
{
    using System;

    using Bank.Customers;

    public class Deposit : Account, IDepositable
    {
        private decimal savedInterestRate;

        public Deposit(Customer inputCustomer, decimal inputInterestRate)
            : base(inputCustomer, inputInterestRate)
        {
            this.savedInterestRate = inputInterestRate;
            this.SetInterestRate();
        }

        /// <summary>
        /// Draw given sum.
        /// </summary>
        /// <param name="amount"></param>
        public void DrawSum(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("The amount for the draw must not be negative number.");
            }

            if (amount > this.Balance)
            {
                throw new InvalidOperationException("The balance of the account is less than the amount for the draw.");
            }

            this.Balance = this.Balance - amount;
            this.SetInterestRate();
        }

        /// <summary>
        /// Deposits given sum.
        /// </summary>
        /// <param name="amount"></param>
        public void DepositSum(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("The amount for the deposit must not be negative number.");
            }

            if (this.Balance == decimal.MaxValue)
            {
                throw new InvalidProgramException("The bank account has maximum ballance. Contact the software maintenance.");
            }

            this.Balance = this.Balance + amount;

            this.SetInterestRate();
        }

        /// <summary>
        /// If the balance of the account is less than 1000 the interest rate is equal to zero.
        /// Otherwise it is equal to the input interest rate.
        /// </summary>
        private void SetInterestRate()
        {
            if (this.Balance < 1000)
            {
                this.InterestRate = 0;
            }
            else
            {
                this.InterestRate = this.savedInterestRate;
            }
        }
    }
}
