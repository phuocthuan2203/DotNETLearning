namespace DemoOOP;

public class Cat : Animal, IPet
{
    public Cat(string name) : base(name) { }

    // Implement abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    // Implement interface method
    public void Play()
    {
        Console.WriteLine($"{Name} is playing with a ball of yarn.");
    }
}