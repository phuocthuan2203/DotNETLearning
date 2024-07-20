namespace Part14_Interface;

public class ConsoleReadable : IDoubleReadable
{
    public string Name => "ConsoleReadable";

    public int ReadInt()
    {
        Console.WriteLine("Nhap int: ");
        return int.Parse(Console.ReadLine() ?? string.Empty);
    }

    public string ReadString()
    {
        Console.WriteLine("Nhap string: ");
        return Console.ReadLine() ?? string.Empty;
    }

    public double ReadDouble()
    {
        Console.WriteLine("Nhap double");
        return double.Parse(Console.ReadLine() ?? string.Empty);
    }
}