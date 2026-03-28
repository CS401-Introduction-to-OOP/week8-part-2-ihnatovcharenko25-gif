namespace Week8;

public abstract class Resource
{
    public string Name { get; private set; }
    public bool IsOpen { get; protected set; }
    
    public abstract void Open();
    public abstract void Close();

    public Resource(string name, bool isOpen = false)
    {
        Name = name;
        IsOpen = isOpen;
    }
}