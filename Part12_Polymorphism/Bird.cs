namespace Part12_Polymorphism;

public class Bird : Animal
{
    public override void Move()
    {
        Console.WriteLine("Bird Flying");
    }

    public new void A()
    {
        Console.WriteLine("Bird.A()");
    }
}