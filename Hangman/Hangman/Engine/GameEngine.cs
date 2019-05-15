namespace Hangman.Engine
{
    using Hangman.Contracts;

    public abstract class GameEngine : IGameEngine
    {

        public IRenderer Render { get; }

        public IReader Reader { get; }

        public GameEngine(IRenderer render, IReader reader)
        {
            this.Render = render;
            this.Reader = reader;
        }

        public abstract void Run();
        
    }
}
