using static System.Console;

namespace Part1_FirstProgram;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        FindMaxOfFiveNums(numbers);

        WriteLine("Print arg:");
        PrintArg(args);

        GetUserInput();

    }

    static void GetUserInput()
    {
        WriteLine("Enter your age:");
        char age = Convert.ToChar(ReadLine() ?? string.Empty);
        WriteLine("Your age is: " + age);

        // wait for the next key
        WriteLine("Press any key to continue...");
        ReadKey();
        WriteLine();

        // read(): return the ascii value of the character
        Write("Input using Read() - ");
        var userInput = Read();
        WriteLine("Ascii Value = {0}",userInput);
    }

    static void FindMaxOfFiveNums(int[] numbers)
    {
        for (int i = 0; i < 5; i++)
        {
            WriteLine($"Enter integer {i + 1}: ");
            numbers[i] = int.Parse(ReadLine() ?? throw new InvalidOperationException());
        }

        int largest = numbers[0];

        if (numbers[1] > largest)
        {
            largest = numbers[1];
        }
        
        if (numbers[2] > largest)
        {
            largest = numbers[2];
        }
        
        if (numbers[3] > largest)
        {
            largest = numbers[3];
        }
        
        if (numbers[4] > largest)
        {
            largest = numbers[4];
        }

        WriteLine($"The largest number: {largest}");
    }

    static void PrintArg(string[] args)
    {
        if (args.Length > 0)
        {
            foreach (var arg in args)
            {
                WriteLine(arg);
            }
        }
    }
}