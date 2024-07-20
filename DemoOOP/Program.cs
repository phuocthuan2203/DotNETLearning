namespace DemoOOP;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Dog and Cat
        Dog dog = new Dog("Buddy");
        Cat cat = new Cat("Whiskers");

        // Demonstrate polymorphism
        Animal myDog = dog;
        Animal myCat = cat;

        myDog.MakeSound(); // Output: Bark
        myCat.MakeSound(); // Output: Meow

        // Demonstrate encapsulation and non-abstract method
        myDog.Sleep(); // Output: Buddy is sleeping.
        myCat.Sleep(); // Output: Whiskers is sleeping.

        // Demonstrate interface implementation
        IPet petDog = dog;
        IPet petCat = cat;

        petDog.Play(); // Output: Buddy is playing fetch.
        petCat.Play(); // Output: Whiskers is playing with a ball of yarn.

        // Create instance of Person
        Person person = new Person("Alice", 30);
        person.Introduce(); // Output: Hi, I'm Alice and I'm 30 years old.

        // Modify fields using properties
        person.Age = 31;
        person.Name = "Bob";
        person.Introduce(); // Output: Hi, I'm Bob and I'm 31 years old.

        // Trying to set a negative age will throw an exception
        try
        {
            person.Age = -1;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message); // Output: Age cannot be negative
        }
    }
}
