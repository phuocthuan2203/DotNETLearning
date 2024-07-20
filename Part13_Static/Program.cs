using System.Threading.Channels;

namespace Part13_Static;

internal class Program
{
    private static void Main(string[] args)
    {
        // static member - start
        var c1 = new C()
        {
            // x = 1111
        };
        
        var c2 = new C()
        {
            // x = 2222
        };
        Console.WriteLine(C.X);

        C.X = 999;
        Console.WriteLine(C.X);
        
        F1();
        Console.WriteLine(C.X);
        
        C.F();
        Console.WriteLine(C.X);

        Console.WriteLine("------------------");
        Console.WriteLine(D.Z);
        // static member - end
        
        // extension method - start
        Person person = new()
        {
            Id = 999,
            Name = "Thuan"
        };
        person.Print();
        // extension method - end
        
        Console.WriteLine("------------------");
        // singleton - start
        for (var i = 0; i < 5; i++)
        {
            // AccessCounter.Counter++; // it's hard to control the access -> use singleton
            Console.WriteLine(AccessCounter.GetInstance().Inc());
        }
        // singleton - end
        
    }

    private static void F1()
    {
        C.X = 1234;
    }
}