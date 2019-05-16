namespace Hangman.Contracts
{
    public interface IDrawable
    {
        void Assets();

        void MistakeAnimation(int mistake);
    }
}
