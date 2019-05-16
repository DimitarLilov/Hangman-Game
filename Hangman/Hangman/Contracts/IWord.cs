namespace Hangman.Contracts
{
    public interface IWord
    {
        string MaskedWord { get; }

        bool ContainsLetter(char letter);

        int NumberOfLetter(char letter);

        string RevealLetter(char letter);

        bool CheckIfWordIsRevealed();
    }
}
