using System;

namespace MBINCompiler.Source.Commands
{

    internal class RegisterCommand : Command<RegisterCommand>
    {

        public override int ExecuteCommand(CommandLineParser options)
        {
            const string name = "PATH";
            string pathvar = System.Environment.GetEnvironmentVariable(name);
            var value = pathvar + ';' + Environment.CurrentDirectory;
            var target = EnvironmentVariableTarget.Machine;
            System.Environment.SetEnvironmentVariable(name, value, target);
            return CommandLine.ShowSuccess();
        }
    }

}
