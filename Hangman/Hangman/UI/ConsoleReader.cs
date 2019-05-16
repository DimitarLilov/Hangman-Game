namespace Hangman.UI
{
    using System;
    using Hangman.Contracts;

    public class ConsoleReader : IReader
    {
        public char ReadKey()
        {
            return Console.ReadKey().KeyChar;
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
