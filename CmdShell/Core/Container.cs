using Microsoft.Extensions.DependencyInjection;

namespace CmdShell.Core;

internal class Container
{
    private static IServiceProvider Provider { get; set; } = null!;
    public static IServiceCollection Services { get; } = new ServiceCollection();

    public static void BuildContainer()
    {
        Provider = Services.BuildServiceProvider();
    }
    public static T? GetKeyedService<T>(object? serviceKey)
    {
        return Provider.GetKeyedService<T>(serviceKey);
    }
    public static T GetRequiredKeyedService<T>(object? serviceKey) where T : notnull
    {
        return Provider.GetRequiredKeyedService<T>(serviceKey);
    }
    public static T? GetService<T>()
	{
		return Provider.GetService<T>();
	}
	public static T GetRequiredService<T>() where T : notnull
    {
		return Provider.GetRequiredService<T>();
	}
}
