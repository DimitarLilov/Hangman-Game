namespace Hangman.Contracts
{
    /// <summary>
    /// Abstraction for game engine
    /// </summary>
    public interface IGameEngine
    {
        /// <summary>
        ///  Property for accessing the drawing device.  
        /// </summary>
        IDrawable DrawManager { get; }

        /// <summary>
        ///  Property for accessing the user`s input.  
        /// </summary>
        IReader Reader { get; }

        /// <summary>
        ///  Method to start the business logic
        /// </summary>
        void Run();
    }
}
