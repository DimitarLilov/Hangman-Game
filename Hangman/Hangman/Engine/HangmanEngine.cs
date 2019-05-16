namespace Hangman.Engine
{
    using Hangman.Contracts;
    using Hangman.Utils;

    public class HangmanEngine : GameEngine
    {
        private readonly IWord word;

        private readonly IPlayer player;

        public HangmanEngine(IDrawable drawManager, IReader reader, IWord word, IPlayer player)
            : base(drawManager, reader)
        {
            this.word = word;
            this.player = player;
        }

        public override void Run()
        {
            this.DrawManager.Clear();
            this.DrawManager.DrawAssets();
            this.DrawManager.DrawMaskedWord(this.word.MaskedWord);

            while (true)
            {
                if (this.player.Lives <= 0)
                {
                    this.DrawManager.DrawLostMessage(this.word.SecretWord);
                    break;
                }
                if (this.word.CheckIfWordIsRevealed())
                {
                    this.DrawManager.DrawWinMessage();
                    break;
                }

                this.DrawManager.DrawEnterLetterMessage();
                char letter = char.ToLower(this.Reader.ReadKey().KeyChar);
                this.DrawManager.DrawNewLine();

                if(this.IsValidLetter(letter))
                {
                    if (!this.word.ContainsLetter(letter))
                    {
                        this.DrawManager.DrawUnrevealedLetter(letter);
                        this.player.Lives--;
                        this.DrawManager.DrawMistakeAnimation(GlobalConstants.PlayerLives - this.player.Lives);
                    }
                    else
                    {
                        int numberOfLetter = this.word.NumberOfLetter(letter);
                        this.DrawManager.DrawRevealedLetter(numberOfLetter);

                        this.DrawManager.DrawMaskedWord(this.word.RevealLetter(letter));
                    }
                }
                else
                {
                    this.DrawManager.IncorrectLetter();
                }
            }

            this.EndGame();
        }

        private bool IsValidLetter(char letter)
        {
            return (letter >= 'A' && letter <= 'Z') || (letter >= 'a' && letter <= 'z');
        }

        private void EndGame()
        {
            this.DrawManager.PlayAgain();
            
            string response = this.Reader.ReadKey().KeyChar.ToString().ToUpper();

            while (response != "Y" && response != "N")
            {
                this.DrawManager.PlayAgain();
                response = this.Reader.ReadKey().KeyChar.ToString().ToUpper();
            }

            if (response == "Y")
            {
                Startup.Main();
            }
            this.DrawManager.DrawNewLine();
        }
    }
}