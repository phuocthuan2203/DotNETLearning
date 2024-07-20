namespace Part11_OOP;

public class Field
{
    private string _name; // field

    public Field(string name)
    {
        this._name = name;
    }

    public void PrintName()
    {
        Console.WriteLine(_name);
    }
}

public class Property
{
    private string? _name; // backing field

    private string? Name // property
    {
        get => _name;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this._name = value;
            }
            else
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
        }
    }

    public Property(string name)
    {
        Name = name; // Using the property. Calling the set method, the 'name' is the 'value' variable
    }

    public void PrintName()
    {
        Console.WriteLine(Name); // using the property. Call the get method and return the _name
    }
}