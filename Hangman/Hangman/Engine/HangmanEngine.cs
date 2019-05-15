namespace Hangman.Engine
{
    using System;
    using Hangman.Contracts;

    public class HangmanEngine : GameEngine
    {
        private readonly IRandomWordGenerator randomWordGenerator;

        public HangmanEngine(IRenderer render, IReader reader, IRandomWordGenerator randomWordGenerator) : base(render, reader)
        {
            this.randomWordGenerator = randomWordGenerator;
        }

        public override void Run()
        {
        }
    }
}
