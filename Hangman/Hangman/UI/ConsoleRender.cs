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

        public void WriteLine(string message, params object[] param)
        {
            Console.WriteLine(message, param);
        }
    }
}
