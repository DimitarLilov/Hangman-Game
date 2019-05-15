namespace Hangman.Engine
{
    using Hangman.Contracts;

    public abstract class GameEngine : IGameEngine
    {

        private readonly IRenderer render;

        private readonly IReader reader;

        public GameEngine(IRenderer render, IReader reader)
        {
            this.render = render;
            this.reader = reader;
        }

        public IRenderer Render => this.render;

        public IReader Reader => this.reader;

        public abstract void Run();
        
    }
}
