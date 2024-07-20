namespace Part11_ClassLibrary1;

public abstract class Printer
{
    public string Name { get; set; }
    private int Age { get; set; }
    private string City { get; set; }

    public required string State;

    // Constructor with parameters
    public Printer(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }

    // Parameterless constructor
    public Printer()
    {
    }

    public void Print(string name)
    {
        Console.WriteLine(name);
    }

    public abstract void MyAbstractClass();
}