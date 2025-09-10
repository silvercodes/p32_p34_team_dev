namespace CmdShell;

public abstract class Command
{
    public abstract string Signature { get; }
    public abstract string Title { get; }
    public List<CommandArgument>? Arguments { get; internal set; } = null;
    public List<CommandOption>? Options { get; internal set; } = null;
    public virtual string Description { get; } = string.Empty;
    public virtual string Help { get; } = string.Empty;
    public virtual bool Hidden { get; set; } = false;
    public Command()
    {
    }

    public abstract void Execute();
}
