namespace Hangman.Engine
{
    using System;
    using Hangman.Contracts;

    public class HangmanEngine : GameEngine
    {
        private readonly IRandomWordGenerator randomWordGenerator;

        private readonly IPlayer player;

        public HangmanEngine(IRenderer render, IReader reader, IRandomWordGenerator randomWordGenerator, IPlayer player) : base(render, reader)
        {
            this.randomWordGenerator = randomWordGenerator;
            this.player = player;
        }

        public override void Run()
        {
            Render.Clear();
        }
    }
}