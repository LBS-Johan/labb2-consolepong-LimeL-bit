namespace Labb2_ConsolePong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameSpeed = 25; //milliseconds per update
            Game game = new Game();
            game.StartGame();

            while (true)
            {
                if (game.Run() == false)
                {
                    Console.WriteLine("Game over");
                    break;
                }

                Thread.Sleep(gameSpeed);
            }
        }
    }
}
