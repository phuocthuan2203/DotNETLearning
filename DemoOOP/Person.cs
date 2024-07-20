namespace DemoOOP;

public class Person
{
    // Field
    private int age;

    // Property
    public string Name { get; set; }

    // Property with validation
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Age cannot be negative");
            }
        }
    }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }
}
