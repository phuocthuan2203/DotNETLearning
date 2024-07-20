namespace DemoOOP;

public class Dog : Animal, IPet
{
    public Dog(string name) : base(name) { }

    // Implement abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    // Implement interface method
    public void Play()
    {
        Console.WriteLine($"{Name} is playing fetch.");
    }
}