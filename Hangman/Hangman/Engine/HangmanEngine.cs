namespace Hangman.Engine
{
    using System.Collections.Generic;
    using Hangman.Contracts;
    using Hangman.Utils;

    public class HangmanEngine : GameEngine
    {
        private readonly IWord word;

        private readonly IPlayer player;

        private readonly ICollection<char> historyLetters;

        public HangmanEngine(IDrawable drawManager, IReader reader, IWord word, IPlayer player)
            : base(drawManager, reader)
        {
            this.word = word;
            this.player = player;
            this.historyLetters = new HashSet<char>();
        }

        public IWord Word => this.word;

        public IPlayer Player => this.player;

        public override void Run()
        {
            this.DrawManager.Clear();
            this.DrawManager.DrawAssets();
            this.DrawManager.DrawMaskedWord(this.Word.MaskedWord);

            while (true)
            {
                if (this.Player.Lives <= 0)
                {
                    this.DrawManager.DrawLostMessage(this.Word.SecretWord);
                    this.DrawManager.DrawMaskedWord(string.Join(" ", this.Word.SecretWord.ToCharArray()));
                    break;
                }

                if (this.Word.CheckIfWordIsRevealed())
                {
                    this.DrawManager.DrawWinMessage();
                    break;
                }

                this.DrawManager.DrawEnterLetterMessage();
                char letter = char.ToLower(this.Reader.ReadKey());
                this.DrawManager.DrawNewLine();

                if (!this.historyLetters.Contains(letter))
                {
                    this.historyLetters.Add(letter);

                    if (this.IsValidLetter(letter))
                    {
                        if (!this.Word.ContainsLetter(letter))
                        {
                            this.DrawManager.DrawUnrevealedLetter(letter);
                            this.Player.Lives--;
                            this.DrawManager.DrawMistakeAnimation(GlobalConstants.PlayerLives - this.Player.Lives);
                        }
                        else
                        {
                            int numberOfLetter = this.Word.NumberOfLetter(letter);
                            this.DrawManager.DrawRevealedLetter(numberOfLetter);

                            this.DrawManager.DrawMaskedWord(this.Word.RevealLetter(letter));
                        }
                    }
                    else
                    {
                        this.DrawManager.IncorrectLetter();
                    }
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

            char response = char.ToLower(this.Reader.ReadKey());

            while (response != 'y' && response != 'n')
            {
                this.DrawManager.PlayAgain();
                response = char.ToLower(this.Reader.ReadKey());
            }

            if (response == 'y')
            {
                Startup.Main();
            }

            this.DrawManager.DrawNewLine();
        }
    }
}