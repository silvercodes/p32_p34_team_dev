namespace CmdShell.Core.Build;

public class CommandBuilder
{
    public void Build(Command cmd)
    {
        System.Console.WriteLine(cmd.Title);
    }
}
