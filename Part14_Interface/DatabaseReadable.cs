namespace Part14_Interface;

public class DatabaseReadable : IReadable
{
    public string Name => "DatabaseReadable";
    
    public int ReadInt()
    {
        return 100;
    }

    public string ReadString()
    {
        return "NGUYEN PHUOC THUAN";
    }
}