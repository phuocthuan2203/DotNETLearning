namespace Part13_Static;

public static class D
{
    public static int Z = 999;

    static D()
    {
        Console.WriteLine(Z);
        Console.WriteLine("[D]");
    }
}