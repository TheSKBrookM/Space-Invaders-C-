namespace SpaceInvaders
{
    internal class Program
    {
        static GameEngine gameEngine;

        static GameSettings gameSettings;

        static void Main(string[] args)
        {
            Init();

            gameEngine.Run();
        }

        public static void Init()
        {
            gameSettings = new GameSettings();
            gameEngine = GameEngine.GetGameEngine(gameSettings);

        }
    }
}