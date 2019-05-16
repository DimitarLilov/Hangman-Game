namespace Hangman
{
    using System;
    using Hangman.Utils;

    public class Startup
    {
        public static void Main()
        {
            var game = Game.Instance;

            game.Start();
        }
    }
}
