namespace Hangman.Utils
{
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
        }
    }
}
