namespace MementoPattern
{
    public interface IPlayer
    {
        Memento SaveMemento();

        void RestoreMemento(Memento memento);
    }
}
