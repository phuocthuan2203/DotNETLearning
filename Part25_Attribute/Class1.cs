namespace Part25_Attribute;

// [Obsolete("This is the message", false)]
public class Class1
{
    // [ObsoleteAttribute()]
    [DbMethod("Customers")]
    private static void PrintHelloWorld1()
    {
        Console.WriteLine("Hello, Customers!");
    }

    [DbMethod("Users")]
    private static void PrintHelloWorld2()
    {
        Console.WriteLine("Hello, Users!");
    }
}