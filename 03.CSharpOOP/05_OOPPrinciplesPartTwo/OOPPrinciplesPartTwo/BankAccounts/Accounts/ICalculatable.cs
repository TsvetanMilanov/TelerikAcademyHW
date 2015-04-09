namespace Bank.Accounts
{
    public interface ICalculatable
    {
        decimal CalculateInterestForPeriod(decimal months);
    }
}
