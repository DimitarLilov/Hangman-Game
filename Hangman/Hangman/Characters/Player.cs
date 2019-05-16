using Hangman.Contracts;
using Hangman.Utils;

namespace Hangman.Characters
{
    public class Player : IPlayer
    {
        public Player()
        {
            this.Lives = GlobalConstants.PlayerLives;
        }

        public int Lives { get; }
    }
}
