using System.Collections;

namespace CmdShell;

public class CommandCollection: IEnumerable<Command>
{
    private List<Command> commands = new List<Command>();

    public void Add(Command command)
    {
        // TODO: validate command name
        commands.Add(command);
    }

    public IEnumerator<Command> GetEnumerator()
    {
        return commands.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
