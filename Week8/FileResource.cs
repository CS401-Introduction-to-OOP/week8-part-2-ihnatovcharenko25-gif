using System.Xml;

namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
        
    }
    
    public override void Open()
    {
        Console.WriteLine($"{Name} is opened");
    }
    
    public override void Close()
    {
        Console.WriteLine($"{Name} is closed");
    }
    public void Dispose()
    {
        Close();
    }

}