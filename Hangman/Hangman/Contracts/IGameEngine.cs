namespace Hangman.Contracts
{
    public interface IGameEngine
    {
        IDrawable DrawManager { get; }

        IReader Reader { get; }

        void Run();
    }
}
