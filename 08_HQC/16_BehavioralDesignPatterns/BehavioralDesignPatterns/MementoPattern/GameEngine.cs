namespace MementoPattern
{
    public class GameEngine
    {
        public void FinishFirstQuest(Player player)
        {
            player.Money += 100;
            player.IsAlive = true;
            player.Location = "DarkForest";
        }

        public void KillPlayer(Player player)
        {
            player.Money = 0;
            player.IsAlive = false;
            player.Location = "Nowhere";
        }
    }
}
