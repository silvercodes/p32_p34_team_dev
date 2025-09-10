using CmdShell.Bootstrappers;
using CmdShell.Core.Registrators;

namespace CmdShell.Core;

internal class Kernel: Container
{
    private List<IServiceRegistrator> registrators = new List<IServiceRegistrator>();
    private List<IBootstrapper> bootstrtappers = new List<IBootstrapper>();
    private CommandCollection commands;
    public Kernel(CommandCollection commands)
    {
        this.commands = commands;

        SetupRegistrators();
        SetupBootstrappers();

        Build();
    }

    public void Handle()
    {

    }

    private void SetupRegistrators()
    {
        registrators.Add(new DefaultServiceRegistrtator(commands));
    }

    private void SetupBootstrappers()
    {
        bootstrtappers.Add(new DefaultBootstrapper());
    }

    private void Build()
    {
        registrators.ForEach(r => r.Register());
        Kernel.BuildContainer();
        bootstrtappers.ForEach(b => b.Boot());
    }
}
