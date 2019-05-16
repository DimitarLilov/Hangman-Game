namespace Hangman.UI
{
    using Hangman.Contracts;
    using Hangman.Utils;

    public class Draw : IDrawable
    {
        private readonly IFileReader fileReader;

        private readonly IRenderer render;

        public Draw(IFileReader fileReader, IRenderer render)
        {
            this.fileReader = fileReader;
            this.render = render;
        }

        public void Assets()
        {
            RenderLogo();
            RenderGibbet();
        }

        public void MistakeAnimation(int mistake)
        {
            switch (mistake)
            {
                case 1:
                    this.RenderMistake(0,"O");
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
            this.render.WritePosition(GlobalConstants.ChairLeftStartPosition, GlobalConstants.ChairTopStartPosition, new string(' ',GlobalConstants.ChairWidth));
            this.render.WritePosition(GlobalConstants.ChairLeftStartPosition, GlobalConstants.ChairTopStartPosition + 1 , new string(' ', GlobalConstants.ChairWidth));
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
