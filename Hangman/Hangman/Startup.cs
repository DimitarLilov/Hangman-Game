namespace Hangman
{
    using Hangman.Utils;

    public class Startup
    {
        static void Main()
        {
            var game = Game.Instance;

            game.Start();
        }
    }
}
