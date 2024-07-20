namespace Part13_Static;

public static class PersonExt
{
    public static void Print(this Person person)
    {
        Console.WriteLine($"ID: {person.Id}");
        Console.WriteLine($"Name: {person.Name}");
    }
}