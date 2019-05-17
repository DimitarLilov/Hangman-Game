namespace Hangman.Contracts
{
    public interface IDrawable
    {
        /// <summary>
        /// Method for drawing assets.
        /// </summary>
        void DrawAssets();

        /// <summary>
        /// Method for drawing mistake animation.
        /// </summary>
        void DrawMistakeAnimation(int mistakes);

        /// <summary>
        /// Method for clear the output.
        /// </summary>
        void Clear();

        /// <summary>
        /// Method for drawing game over messsage.
        /// </summary>
        void DrawLostMessage(string secretWord);

        void DrawWinMessage();

        void DrawEnterLetterMessage();

        void DrawNewLine();

        void DrawUnrevealedLetter(char letter);

        void DrawRevealedLetter(int numberOfLetter);

        void DrawMaskedWord(string word);

        void IncorrectLetter();

        void PlayAgain();
    }
}
