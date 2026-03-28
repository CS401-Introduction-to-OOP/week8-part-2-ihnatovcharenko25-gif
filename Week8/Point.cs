namespace Week8;

public struct Point
{
    public int X { get; private set; } 
    public int Y { get; private set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Print()
    {
        Console.WriteLine($"{X}, {Y}");
    }
}