namespace MementoPattern
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            GameEngine gameEngine = new GameEngine();
            GameSaver gameSaver = new GameSaver();

            Player heroe = new Player("Pesho");
            Console.WriteLine("Hero at game start:");
            Console.WriteLine(heroe.Introduce());

            Memento startGameSave = new Memento(heroe.Money, heroe.IsAlive, heroe.Location);
            gameSaver.SaveGame(startGameSave);

            gameEngine.FinishFirstQuest(heroe);
            Console.WriteLine("\nHero after first quest:");
            Console.WriteLine(heroe.Introduce());

            Memento afterFirstQuestSave = new Memento(heroe.Money, heroe.IsAlive, heroe.Location);
            gameSaver.SaveGame(afterFirstQuestSave);

            gameEngine.KillPlayer(heroe);
            Console.WriteLine("\nHero after kill:");
            Console.WriteLine(heroe.Introduce());

            Memento afterFirstQuestLoadGame = gameSaver.LoadLastSavedGame();
            heroe.RestoreMemento(afterFirstQuestLoadGame);
            Console.WriteLine("\nHero after load game:");
            Console.WriteLine(heroe.Introduce());
        }
    }
}
