namespace Week8;

public struct Point
{
    public int X { get; set; } 
    public int Y { get; set; }

    public Point(int x=0, int y=0)
    {
        X = x;
        Y = y;
    }

    public void Print()
    {
        Console.WriteLine($"{X}, {Y}");
    }
}