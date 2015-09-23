namespace MementoPattern
{
    using System.Collections.Generic;

    public class GameSaver
    {
        public GameSaver()
        {
            this.SavedGames = new Stack<Memento>();
        }

        private Stack<Memento> SavedGames { get; set; }

        public void SaveGame(Memento memento)
        {
            this.SavedGames.Push(memento);
        }

        public Memento LoadLastSavedGame()
        {
            Memento lastSavedGame = this.SavedGames.Pop();

            return lastSavedGame;
        }
    }
}
