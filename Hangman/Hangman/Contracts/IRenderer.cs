namespace Hangman.Contracts
{

    /// <summary>
    /// Abstraction for rendering on the UI
    /// </summary>
    public interface IRenderer
    {

        /// <summary>
        /// Method for writing the text output
        /// </summary>
        void WriteLine(string message, params object[] param);


        /// <summary>
        /// Method for clear the text output
        /// </summary>
        void Clear();
    }
}
