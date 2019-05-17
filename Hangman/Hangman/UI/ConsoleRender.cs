namespace Hangman.UI
{
    using System;
    using Hangman.Contracts;

    public class ConsoleRender : IRenderer
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Write(string message, params object[] param)
        {
            Console.Write(message, param);
        }

        public void WriteLineRedColor(string message, params object[] param)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message, param);
            Console.ResetColor();
        }

        public void WriteLineYellowColor(string message, params object[] param)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message, param);
            Console.ResetColor();
        }

        public void WriteLine(string message, params object[] param)
        {
            Console.WriteLine(message, param);
        }

        public void WritePosition(int x, int y, string message, params object[] param)
        {
            int currentLeft = Console.CursorLeft;
            int currentTop = Console.CursorTop;

            Console.SetCursorPosition(x, y);
            Console.WriteLine(message, param);

            Console.SetCursorPosition(currentLeft, currentTop);
        }
    }
}
