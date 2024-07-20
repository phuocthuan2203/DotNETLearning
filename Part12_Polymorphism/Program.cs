namespace Part12_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        // var rand = new Random();
        // Animal animal = GetAnimal(rand.Next(0, 2));
        // animal.Move();

        Bird animal = new Bird();
        animal.A();
    }

    static Animal GetAnimal(int id)
    {
        switch (id)
        {
            case 0:
                return new Dog();
            case 1:
                return new Bird();
            default:
                return new Fish();
        }
    }
}