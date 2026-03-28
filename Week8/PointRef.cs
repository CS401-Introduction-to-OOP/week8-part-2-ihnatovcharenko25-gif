namespace Week8;

public class PointRef
{
    public int X { get; private set; } 
    public int Y { get; private set; }

    public PointRef(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Print()
    {
        Console.WriteLine($"{X}, {Y}");
    }
}