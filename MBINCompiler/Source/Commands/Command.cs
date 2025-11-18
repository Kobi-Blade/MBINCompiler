namespace MBINCompiler.Source.Commands
{

    public abstract class Command<T> where T : Command<T>, new()
    {

        public abstract int ExecuteCommand(CommandLineParser options);

        public static int Execute(CommandLineParser options)
        {
            return new T().ExecuteCommand(options);
        }

    }

}
