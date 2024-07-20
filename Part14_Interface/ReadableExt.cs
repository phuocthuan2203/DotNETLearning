namespace Part14_Interface;

public static class ReadableExt
{
    public static void WriteName(this IReadable readable)
    {
        Console.WriteLine(readable.Name);
    }
}