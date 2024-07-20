namespace Part12_Polymorphism;

public class Fish : Animal
{
    public sealed override void Move()
    {
        Console.WriteLine("Fish Swimming");
    }
}