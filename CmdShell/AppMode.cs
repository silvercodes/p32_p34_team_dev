namespace CmdShell;

[Flags]
public enum AppMode: uint
{
    None = 0,
    Console = 1,
    Http = 2,
    Ssh = 4,
    All = ~None,
}
