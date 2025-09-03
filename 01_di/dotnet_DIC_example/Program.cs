using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();
services.AddSingleton<IRenderer, Renderer3d>();
services.AddSingleton<ILoader, FileLoader>();
services.AddTransient<Unit>();

ServiceProvider provider = services.BuildServiceProvider();

//IRenderer renderer = provider.GetRequiredService<IRenderer>();
//renderer.Render();

Unit u1 = provider.GetRequiredService<Unit>();
u1.Show();

Unit u2 = new Unit(new Renderer3d(new FileLoader()));
u2.Show();

interface IRenderer
{
    public void Render();
} 
interface ILoader
{
    public void Load();
}


class Renderer2d : IRenderer
{
    public void Render() => Console.WriteLine("Renderer2d");
}
class Renderer3d : IRenderer
{
    public ILoader Loader { get; set; }
    public Renderer3d(ILoader loader)
    {
        Loader = loader;
    }
    public void Render()
    {
        Loader.Load();
        Console.WriteLine("Renderer3d");
    }
}

class FileLoader : ILoader
{
    public void Load() => Console.WriteLine("FileLoader.Load()");
}


class Unit
{
    public IRenderer Renderer { get; set; }
    public Unit(IRenderer renderer)
    {
        Renderer = renderer;
    }

    public void Show()
    {
        //
        Renderer.Render();
    }
}
