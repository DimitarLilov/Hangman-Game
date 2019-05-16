namespace Hangman.Engine
{
    using Hangman.Contracts;
    using Hangman.Utils;

    public class HangmanEngine : GameEngine
    {
        private readonly IWord word;

        private readonly IPlayer player;

        private readonly IDrawable draw;

        public HangmanEngine(IRenderer render, IReader reader,IDrawable draw, IWord word, IPlayer player)
            : base(render, reader)
        {
            this.word = word;
            this.player = player;
            this.draw = draw;
        }

        public override void Run()
        {
            Render.Clear();
            this.draw.Assets();
            this.PrintMaskedWord(this.word.MaskedWord);

            while (true)
            {
                if (this.player.Lives <= 0)
                {
                    this.Render.WriteLine(GlobalConstants.Lost);
                    this.Render.WriteLine(GlobalConstants.SecretWord + this.word.SecretWord);
                    break;
                }
                if (this.word.CheckIfWordIsRevealed())
                {
                    this.Render.WriteLine(GlobalConstants.Win);
                    break;
                }

                this.Render.Write(GlobalConstants.EnterLetter);
                char letter = char.ToLower(this.Reader.ReadKey().KeyChar);
                this.Render.WriteLine(string.Empty);

                if(this.IsValidLetter(letter))
                {
                    if (!this.word.ContainsLetter(letter))
                    {
                        this.Render.WriteLine(GlobalConstants.UnrevealedLetter + $"'{letter}'");
                        this.player.Lives--;
                        this.draw.MistakeAnimation(GlobalConstants.PlayerLives - this.player.Lives);
                    }
                    else
                    {
                        int numberOfLetter = this.word.NumberOfLetter(letter);
                        string latter = numberOfLetter == 1 ? " letter" : " letters";
                        this.Render.WriteLine(GlobalConstants.RevealedLetter + numberOfLetter + latter);

                        this.PrintMaskedWord(this.word.RevealLetter(letter));
                    }
                }
                else
                {
                    this.Render.WriteLine(GlobalConstants.IncorrectLetter);
                }
            }

            this.EndGame();
        }

        private void PrintMaskedWord(string word)
        {
            this.Render.WritePosition(GlobalConstants.SecretWordLeftPosition, GlobalConstants.SecretWordTopPosition, word);
        }

        private bool IsValidLetter(char letter)
        {
            return (letter >= 'A' && letter <= 'Z') || (letter >= 'a' && letter <= 'z');
        }

        private void EndGame()
        {
            this.Render.WriteLine(GlobalConstants.PlayAgain);
            string response = this.Reader.ReadKey().KeyChar.ToString().ToUpper();

            while (response != "Y" && response != "N")
            {
                this.Render.WriteLine(GlobalConstants.PlayAgain);
                response = this.Reader.ReadKey().KeyChar.ToString().ToUpper();
            }

            if (response == "Y")
            {
                Startup.Main();
            }
            this.Render.WriteLine(string.Empty);
        }
    }
}