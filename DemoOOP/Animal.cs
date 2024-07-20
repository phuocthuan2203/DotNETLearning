namespace DemoOOP;

public abstract class Animal
{
    // Field
    private string name;

    // Property for the field 'name'
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Abstract method
    public abstract void MakeSound();

    // Non-abstract method
    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }

    // Constructor
    public Animal(string name)
    {
        Name = name;
    }
}
