namespace Hangman.Engine
{
    using Hangman.Contracts;

    public class HangmanEngine : GameEngine
    {
        private readonly IRandomGenerator random;

        public HangmanEngine(IRenderer render, IReader reader, IRandomGenerator random) : base(render, reader)
        {
            this.random = random;
        }

        public override void Run()
        {
        }
    }
}
