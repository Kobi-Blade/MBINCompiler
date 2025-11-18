namespace MBINCompiler.Source.Commands
{

    internal class HelpCommand : Command<HelpCommand>
    {

        public override int ExecuteCommand(CommandLineParser options)
        {
            return CommandLine.ShowHelp();
        }
    }

}
