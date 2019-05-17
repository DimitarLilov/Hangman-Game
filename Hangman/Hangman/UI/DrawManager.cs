namespace Hangman.UI
{
    using Hangman.Contracts;
    using Hangman.Utils;

    public class DrawManager : IDrawable
    {
        private readonly IFileReader fileReader;

        private readonly IRenderer render;

        public DrawManager(IFileReader fileReader, IRenderer render)
        {
            this.fileReader = fileReader;
            this.render = render;
        }

        public void DrawAssets()
        {
            this.RenderLogo();
            this.RenderGibbet();
        }

        public void DrawMistakeAnimation(int mistakes)
        {
            switch (mistakes)
            {
                case 1:
                    this.RenderMistake(0, "O");
                    break;
                case 2:
                    this.RenderMistake(0, "|");
                    this.RenderMistake(1, "O");
                    break;
                case 3:
                    this.RenderMistake(0, "|");
                    this.RenderMistake(1, "|");
                    this.RenderMistake(2, "O");
                    break;
                case 4:
                    this.RenderMistake(0, "|");
                    this.RenderMistake(1, "|");
                    this.RenderMistake(2, "|");
                    break;
                case 5:
                    this.GameOver();
                    break;
            }
        }

        public void Clear()
        {
            this.render.Clear();
        }

        public void DrawLostMessage(string secretWord)
        {
            this.render.WriteLineRedColor(GlobalConstants.Lost);
            this.render.WriteLine(GlobalConstants.SecretWord + secretWord);
        }

        public void DrawWinMessage()
        {
            this.render.WriteLineYellowColor(GlobalConstants.Win);
        }

        public void DrawEnterLetterMessage()
        {
            this.render.Write(GlobalConstants.EnterLetter);
        }

        public void DrawNewLine()
        {
            this.render.WriteLine(string.Empty);
        }

        public void DrawUnrevealedLetter(char letter)
        {
            this.render.WriteLine(GlobalConstants.UnrevealedLetter + $"'{letter}'");
        }

        public void DrawRevealedLetter(int numberOfLetter)
        {
            string latter = numberOfLetter == 1 ? " letter" : " letters";
            this.render.WriteLine(GlobalConstants.RevealedLetter + numberOfLetter + latter);
        }

        public void DrawMaskedWord(string word)
        {
            this.render.WritePosition(GlobalConstants.SecretWordLeftPosition, GlobalConstants.SecretWordTopPosition, word);
        }

        public void IncorrectLetter()
        {
            this.render.WriteLine(GlobalConstants.IncorrectLetter);
        }

        public void PlayAgain()
        {
            this.render.WriteLine(GlobalConstants.PlayAgain);
        }

        private void RenderMistake(int index, string symbol)
        {
            this.render.WritePosition(GlobalConstants.MistakeStartLeftPosition, GlobalConstants.MistakeStartTopPosition + index, symbol);
        }

        private void GameOver()
        {
            this.render.WritePosition(GlobalConstants.FaceLeftPosition, GlobalConstants.FaceTopPosition, GlobalConstants.DeathFace);
            this.RemoveChair();
        }

        private void RemoveChair()
        {
            this.render.WritePosition(GlobalConstants.ChairLeftStartPosition, GlobalConstants.ChairTopStartPosition, new string(' ', GlobalConstants.ChairWidth));
            this.render.WritePosition(GlobalConstants.ChairLeftStartPosition, GlobalConstants.ChairTopStartPosition + 1, new string(' ', GlobalConstants.ChairWidth));
            this.render.WritePosition(GlobalConstants.ChairLeftStartPosition, GlobalConstants.ChairTopStartPosition + 2, new string(' ', GlobalConstants.ChairWidth));
        }

        private void RenderLogo()
        {
            string[] lines = this.fileReader.ReaderAllLines(GlobalConstants.LogoPath);

            for (int i = 0; i < lines.Length; i++)
            {
                this.render.WritePosition(GlobalConstants.LeftLogoPosition, i, lines[i]);
            }
        }

        private void RenderGibbet()
        {
            string[] lines = this.fileReader.ReaderAllLines(GlobalConstants.GibbetPath);

            for (int i = 0; i < lines.Length; i++)
            {
                this.render.WritePosition(GlobalConstants.LeftLogoPosition, GlobalConstants.GibbetTopPosition + i, lines[i]);
            }
        }
    }
}
