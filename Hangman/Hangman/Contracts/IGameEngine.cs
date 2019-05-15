namespace Hangman.Contracts
{
    public interface IGameEngine
    {
        IRenderer Render { get; }

        IReader Reader { get; }

        void Run();
    }
}
