using CmdShell.Core;
using CmdShell.Core.Build;

namespace CmdShell.Bootstrappers;

public class DefaultBootstrapper : IBootstrapper
{
    public void Boot()
    {
        CommandBuilder commandBuilder = Kernel.GetRequiredService<CommandBuilder>();

        foreach(Command cmd in Kernel.GetRequiredService<CommandCollection>())
            commandBuilder.Build(cmd);
    }
}
