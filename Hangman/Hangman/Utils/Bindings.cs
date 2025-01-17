﻿namespace Hangman.Utils
{
    using Hangman.Characters;
    using Hangman.Contracts;
    using Hangman.Engine;
    using Hangman.UI;
    using Ninject.Modules;

    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IGameEngine>().To<HangmanEngine>();
            Bind<IRenderer>().To<ConsoleRender>();
            Bind<IReader>().To<ConsoleReader>();
            Bind<IFileReader>().To<FileReader>();
            Bind<IDrawable>().To<DrawManager>();
            Bind<IRandomGenerator>().To<RandomGenerator>();
            Bind<IRandomWordGenerator>().To<RandomWordGenerator>();
            Bind<IPlayer>().To<Player>();
            Bind<IWord>().To<Word>();
        }
    }
}
