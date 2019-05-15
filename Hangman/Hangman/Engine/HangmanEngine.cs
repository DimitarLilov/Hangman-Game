using Hangman.Contracts;

namespace Hangman.Engine
{
    public class HangmanEngine : GameEngine
    {
        public HangmanEngine(IRenderer render, IReader reader) : base(render, reader)
        {
        }

        public override void Run()
        {
            this.Render.WriteLine("A");
        }
    }
}
