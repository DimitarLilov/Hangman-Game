namespace Hangman.Engine
{
    using Hangman.Contracts;

    public abstract class GameEngine : IGameEngine
    {

        private readonly IDrawable drawManager;

        private readonly IReader reader;

        public GameEngine(IDrawable drawManager, IReader reader)
        {
            this.drawManager = drawManager;
            this.reader = reader;
        }

        public IDrawable DrawManager => this.drawManager;

        public IReader Reader => this.reader;

        public abstract void Run();
        
    }
}
