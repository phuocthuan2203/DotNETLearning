namespace Part11_ClassLibrary1.NewDirectory1;

public class LaserPrinter : Printer
{
    public int Resolution { get; set; } = 250;

    public LaserPrinter(string name, int age, string city, int resolution) : base(name, age, city)
    {
        this.Resolution = resolution;
    }

    public override void MyAbstractClass()
    {
        Console.WriteLine("Implementing the abstract class");
    }
}