namespace Hangman.Engine
{
    using Hangman.Contracts;
    using Hangman.Utils;

    public class HangmanEngine : GameEngine
    {
        private readonly IRandomWordGenerator randomWordGenerator;

        private readonly IPlayer player;

        public HangmanEngine(IRenderer render, IReader reader, IRandomWordGenerator randomWordGenerator, IPlayer player) 
            : base(render, reader)
        {
            this.randomWordGenerator = randomWordGenerator;
            this.player = player;
        }

        public override void Run()
        {
            Render.Clear();
            while (true)
            {
                if(this.player.Lives <= 0)
                {
                    Render.WriteLine(GlobalConstants.Lost);
                    break;
                }
                Render.WriteLine("-1");
                this.player.Lives--;
            }

            EndGame();
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