namespace Hangman.Engine
{
    using Hangman.Contracts;
    using Hangman.Utils;

    public class HangmanEngine : GameEngine
    {
        private readonly IWord word;

        private readonly IPlayer player;

        public HangmanEngine(IRenderer render, IReader reader, IWord word, IPlayer player) 
            : base(render, reader)
        {
            this.word = word;
            this.player = player;
        }

        public override void Run()
        {
            Render.Clear();
            while (true)
            {
                this.Render.WriteLine(this.word.SecretWord);

                if (this.player.Lives <= 0)
                {
                    Render.WriteLine(GlobalConstants.Lost);
                    break;
                }
                if (this.word.CheckIfWordIsRevealed())
                {
                    Render.WriteLine(GlobalConstants.Win);
                    break;
                }

                char latter = this.Reader.ReadKey().KeyChar;
                this.Render.WriteLine(string.Empty);

                if(!this.word.ContainsLetter(latter))
                {
                    this.player.Lives--;
                }
                this.Render.WriteLine(this.word.MaskedWord);
                this.Render.WriteLine(this.word.RevealLetter(latter));
                this.Render.WriteLine(string.Empty);

                //this.player.Lives--;
            }

            this.EndGame();
        }

        private void EndGame()
        {
            this.Render.WriteLine(GlobalConstants.PlayAgain);
            string response = this.Reader.ReadKey().KeyChar.ToString().ToUpper();
            this.Render.WriteLine(string.Empty);
            while (response != "Y" && response != "N")
            {
                this.Render.WriteLine(GlobalConstants.PlayAgain);
                response = this.Reader.ReadKey().KeyChar.ToString().ToUpper();
                this.Render.WriteLine(string.Empty);
            }

            if (response == "Y")
            {
                Startup.Main();
            }
        }
    }
}