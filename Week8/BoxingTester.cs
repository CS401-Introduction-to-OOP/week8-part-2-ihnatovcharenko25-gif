namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 30;
        
        // TODO:
        // 1. box a into object
        object obja = a;
        
        // 2. unbox back into int
        int b = (int)obja;
        
        // 3. print all values
        Console.WriteLine($"a={a}, boxed={obja}, unboxed={b}");
        // 4. add comments explaining what happens
        Console.WriteLine($"We are boxing value into reference-type (object obja = a), then unboxing it with (int)");
    }
}