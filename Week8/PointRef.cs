namespace Week8;

public class PointRef
{
    public int X { get; set; } 
    public int Y { get; set; }

    public PointRef(int x=0, int y=0)
    {
        X = x;
        Y = y;
    }

    public void Print()
    {
        Console.WriteLine($"{X}, {Y}");
    }
}