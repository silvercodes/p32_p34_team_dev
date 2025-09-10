using Microsoft.Extensions.DependencyInjection;
using CmdShell.Core;

namespace CmdShell;

public class Application
{
    private AppMode appMode;
    public CommandCollection Commands { get; set; } = new CommandCollection();
    public Application(AppMode appMode)
    {
        this.appMode = appMode;
    }
    public void Run()
    {
        Kernel kernel = new Kernel(Commands);

        kernel.Handle();
    }
}
