namespace Part14_Interface;

public interface IReadable
{
    string Name { get; }
    
    int ReadInt();
    string ReadString();

    static IReadable()
    {
        
    }
    
    // static method in an interface: phải có body, các lớp implement sẽ hưởng phần body sẵn có đó
    static void WriteName(IReadable readable)
    {
        Console.WriteLine(readable.Name);
    }
}