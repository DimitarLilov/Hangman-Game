using Hangman.Utils;

namespace Hangman.Characters
{
    public class Player
    {
        private readonly string name;

        private readonly int lives;

        public Player(string name)
        {
            this.name = name;
            this.lives = GlobalConstants.PlayerLives;
        }

        public string Name => this.name;

        public int Lives => this.lives;
    }
}
