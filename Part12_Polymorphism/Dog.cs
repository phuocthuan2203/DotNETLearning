namespace Part12_Polymorphism;

public class Dog : Animal
{
    public override void Move()
    {
        Console.WriteLine("Dog Running");
    }
}