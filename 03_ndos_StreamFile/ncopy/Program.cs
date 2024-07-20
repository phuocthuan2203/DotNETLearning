namespace ncopy;

class Program
{
    static void Main(string[] args)
    {
        string source = @"/Users/thuannguyenphuoc/Documents/dotNET/TestStream/Program.txt";
        string dest = @"/Users/thuannguyenphuoc/Documents/dotNET/TestStream/Program-copy.txt";

        var buffer = new byte[1024];
        using var instream = File.OpenRead(source);
        using var outstream = File.OpenWrite(dest);

        int n = instream.Read(buffer, 0, buffer.Length);
        while (n > 0)
        {
            Console.WriteLine(n.ToString());
            
            outstream.Write(buffer, 0, n);

            n = instream.Read(buffer, 0, buffer.Length);
        }
    }
}