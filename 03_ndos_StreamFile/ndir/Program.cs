namespace ndir;

class Program
{
    static void Main(string[] args)
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