using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;
using CmdShell.Core;
using CmdShell.Core.Build;
namespace CmdShell.Core.Registrators;

public class DefaultServiceRegistrtator : IServiceRegistrator
{
    private CommandCollection commands;
    public DefaultServiceRegistrtator(CommandCollection commands)
    {
        this.commands = commands;
    }
    public void Register()
    {
        Kernel.Services.AddSingleton<CommandBuilder>();
        Kernel.Services.AddSingleton<CommandCollection>(commands);
    }
}
