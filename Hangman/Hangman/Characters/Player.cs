namespace Hangman.Characters
{
    using Hangman.Contracts;
    using Hangman.Utils;

    public class Player : IPlayer
    {
        public Player()
        {
            this.Lives = GlobalConstants.PlayerLives;
        }

        public int Lives { get; }
    }
}
