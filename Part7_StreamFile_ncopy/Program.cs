namespace Part7_StreamAndFile;

class Program
{
    static void Main(string[] args)
    {
        NCopy();
        
        // NDir();
    }

    static void NCopy()
    {
        string source = @"/Users/thuannguyenphuoc/Documents/dotNET/Part7_StreamFile_ncopy/TestStream/Program.txt";
        string dest = @"/Users/thuannguyenphuoc/Documents/dotNET/Part7_StreamFile_ncopy/TestStream/Program-copy.txt";

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

    static void NDir()
    {
        var path = "/Users";

        var dir = new DirectoryInfo(path);
        var directories = dir.GetDirectories();

        foreach (var d in directories)
        {
            Console.WriteLine($"{d.LastWriteTime:MM/dd/yyyy} {d.LastWriteTime:HH:mm} <DIR> {d.Name}");
        }

        var files = dir.GetFiles();
        foreach (var f in files)
        {
            Console.WriteLine($"{f.LastWriteTime:MM/dd/yyyy} {f.LastWriteTime:HH:mm}     {f.Length:#,###}  {f.Name}");
        }
    }
}