namespace Hangman.Characters
{
    using Hangman.Contracts;
    using Hangman.Utils;

    public class Player : IPlayer
    {
        private int lives;

        public Player()
        {
            this.lives = GlobalConstants.PlayerLives;
        }

        public int Lives { get => this.lives; set => this.lives = value; }
    }
}
