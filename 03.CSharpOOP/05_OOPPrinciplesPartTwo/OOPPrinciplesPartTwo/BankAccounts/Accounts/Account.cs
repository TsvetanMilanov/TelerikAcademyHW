namespace Bank.Accounts
{
    using System;

    using Bank.Customers;

    public abstract class Account : ICalculatable
    {
        private decimal balance;
        private decimal interestRate;

        public Account()
        {
            this.Balance = 0;
        }

        public Account(Customer inputCustomer, decimal inputInterestRate)
            : this()
        {
            this.Customer = inputCustomer;
            this.InterestRate = inputInterestRate;
        }

        /// <summary>
        /// Accounts customer.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Accounts balance. Must NOT be negative number.
        /// </summary>
        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The balance of the account must NOT be negative number.");
                }

                this.balance = value;
            }
        }

        /// <summary>
        /// Returns the interest rate in percents.
        /// </summary>
        public string GetInterestRate
        {
            get
            {
                return string.Format("{0:P1}", this.InterestRate);
            }
        }

        /// <summary>
        /// Accounts interest rate in percent.
        /// </summary>
        protected decimal InterestRate
        {
            get
            {
                return this.interestRate - 1;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The interest rate of the account must NOT be negative number.");
                }

                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("The interest rate of the account must NOT be greater than 100%.");
                }

                this.interestRate = 1 + (value / (decimal)100);
            }
        }

        /// <summary>
        /// Calculates the interest for given period in months.
        /// </summary>
        /// <param name="months"></param>
        /// <returns></returns>
        public virtual decimal CalculateInterestForPeriod(decimal months)
        {
            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("The period must not be negative.");
            }

            decimal result = this.Balance;

            for (int i = 1; i <= months; i++)
            {
                result += result * this.InterestRate;
            }

            result -= this.Balance;

            return result;
        }
    }
}
