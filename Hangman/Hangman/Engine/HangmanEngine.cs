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
            //while (true)
            //{

            //}

            EndGame();
        }

        private void EndGame()
        {
            this.Render.WriteLine(GlobalConstants.PlayAgain);
            string response = this.Reader.ReadLine().ToUpper();
            while (response != "Y" && response != "N")
            {
                this.Render.WriteLine(GlobalConstants.PlayAgain);
                response = this.Reader.ReadLine().ToUpper();
            }

            if (response == "Y")
            {
                Startup.Main();
            }
        }
    }
}