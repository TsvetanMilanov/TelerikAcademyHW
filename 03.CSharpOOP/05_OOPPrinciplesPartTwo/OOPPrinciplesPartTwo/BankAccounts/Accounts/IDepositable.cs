namespace Bank.Accounts
{
    public interface IDepositable
    {
        /// <summary>
        /// Deposits given sum.
        /// </summary>
        /// <param name="amount"></param>
        void DepositSum(decimal amount);
    }
}
