namespace MediatorPattern
{
    public interface ICommander
    {
        void AddSoldier(ISoldier soldier);

        void OrderSoldiersInLine();
    }
}
