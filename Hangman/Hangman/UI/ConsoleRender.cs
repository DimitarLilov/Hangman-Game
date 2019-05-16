﻿namespace Hangman.UI
{
    using System;
    using Hangman.Contracts;

    public class ConsoleRender : IRenderer
    {
        public void Clear()
        {
            Console.Clear();
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
