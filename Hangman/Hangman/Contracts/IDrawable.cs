namespace Hangman.Contracts
{
    public interface IDrawable
    {
        void DrawAssets();

        void DrawMistakeAnimation(int mistake);

        /// <summary>
        /// Method for clear output
        /// </summary>
        void Clear();

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
