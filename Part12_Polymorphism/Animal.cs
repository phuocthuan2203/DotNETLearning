namespace Part12_Polymorphism;

public class Animal
{
    public virtual void Move()
    {
        Console.WriteLine("Move");
    }

    public void A()
    {
        Console.WriteLine("Animal.A()");
    }
}