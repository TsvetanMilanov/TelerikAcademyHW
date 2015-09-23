namespace MediatorPattern
{
    public interface ISoldier
    {
        int Position { get; set; }

        string Report();
    }
}