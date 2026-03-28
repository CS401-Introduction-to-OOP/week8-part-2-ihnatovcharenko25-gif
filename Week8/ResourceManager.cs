namespace Week8;

public class ResourceManager<T> where T : Resource
{
    private List<T> _list = new List<T>();

    public void Add(T resource)
    {
        _list.Add(resource);
    }

    public void OpenAll()
    {
        foreach (var resource in _list)
            resource.Open();
    }
    
    public void CloseAll()
    {
        foreach (var resource in _list)
            resource.Close();
    }
}