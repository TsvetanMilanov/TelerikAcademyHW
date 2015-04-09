namespace Bank.Accounts
{
    using Bank.Customers;

    public class Mortgage : Loan, IDepositable
    {
        public Mortgage(Customer inputCustomer, decimal inputBalance, decimal inputInterestRate)
            : base(inputCustomer, inputBalance, inputInterestRate)
        {
        }

        public override decimal CalculateInterestForPeriod(decimal months)
        {
            if (this.Customer is Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else if (months > 6)
                {
                    months = months - 6;
                }
            }
            else if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    decimal result = this.Balance;

                    for (int i = 1; i <= months; i++)
                    {
                        result += result * this.InterestRate;
                    }

                    result -= this.Balance;

                    return result;
                }
                else if (months > 12)
                {
                    months = months - 12;
                }
            }

            return base.CalculateInterestForPeriod(months);
        }
    }
}
