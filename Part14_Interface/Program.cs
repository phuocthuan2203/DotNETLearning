namespace Part14_Interface;

class Program
{
    static void Main(string[] args)
    {
        var reader = new DatabaseReadable();

        Run(reader);
    }

    static void Run(IReadable  reader)
    {
        reader.WriteName();
        
        IReadable.WriteName(reader);
        
        Console.WriteLine(reader.Name);

        int n = reader.ReadInt();

        string s = reader.ReadString();

        Console.WriteLine($"int: {n}, string = {s}");
    }
}