namespace Part5_Method;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        
        // pass by value
        int firstNum = 1;
        int secondNum = 2;
        PassByValue(firstNum, secondNum);
        Console.WriteLine($"Main - first num = {firstNum}");
        Console.WriteLine($"Main - second num = {secondNum}");
        
        // pass by reference
        int firstRef = 1;
        int secondRef = 2;
        PassByReference(ref firstRef, ref secondRef);
        Console.WriteLine($"Main - first Ref = {firstRef}");
        Console.WriteLine($"Main - second Ref = {secondRef}");
        Console.WriteLine("--------------------");
        
        var mc = new MyClass() { M = 100 }; // [1000] = 9000
        Print(mc);
        // [2000] = [1000] = 9000
        Update(mc);
        Print(mc);

        Console.WriteLine(Add(1, 2));
        
        // swap two num
        Console.WriteLine($"first num before swapped: {firstNum}");
        Console.WriteLine($"second num before swapped: {secondNum}");
        SwapTwoNum(ref firstNum, ref secondNum);
        Console.WriteLine($"first num after swapped: {firstNum}");
        Console.WriteLine($"second num after swapped: {secondNum}");
        
        // fibonacci
        PrintFibonacci(7);
        
        // out keyword
        int i; // declaring variable without assigning value
        Addition(out i);
        Console.WriteLine($"The value of i after using out keyword: {i}");
        
        // params keyword
        int sum1 = SumNumbers(1, 2, 3, 4, 5);
        Console.WriteLine($"sum: {sum1}");

        int[] numbers = { 10, 20, 30 };
        int sum2 = SumNumbers(numbers);
        Console.WriteLine($"sum: {sum2}");

        int sum3 = SumNumbers();
        Console.WriteLine($"sum: {sum3}");
    }

    static void Addition(out int i)
    {
        i = 30;
        i += i;
    }

    static void Print(MyClass mc) => Console.WriteLine($"mc.M = {mc.M}");

    static int Add(int x, int y) => x + y;

    static void Update(MyClass mc) // [2000] = 9000
    {
        // mc = new MyClass() { M = 200 }; // [2000] = 9999
        mc.M = 200;
        Print(mc);
    }

    static void PassByValue(int firstNum, int secondNum)
    {
        Console.WriteLine($"first num = {firstNum}");
        Console.WriteLine($"second num = {secondNum}");

        firstNum++;
        secondNum++;
        
        Console.WriteLine($"first num = {firstNum}");
        Console.WriteLine($"second num = {secondNum}");
    }
    
    static void PassByReference(ref int firstRef, ref int secondRef)
    {
        Console.WriteLine($"first ref = {firstRef}");
        Console.WriteLine($"second ref = {secondRef}");

        firstRef++;
        secondRef++;
        
        Console.WriteLine($"first ref = {firstRef}");
        Console.WriteLine($"second ref = {secondRef}");
    }

    // swap two num
    static void SwapTwoNum(ref int firstNum, ref int secondNum)
    {
        (firstNum, secondNum) = (secondNum, firstNum);
    }
    
    // fibonacci
    static void PrintFibonacci(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("The number of terms should be greater than 0.");
            return;
        }

        long first = 0, second = 1, next;

        Console.WriteLine("Fibonacci sequence up to " + n + " terms:");

        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write(first + " ");
                continue;
            }
            if (i == 2)
            {
                Console.Write(second + " ");
                continue;
            }
            next = first + second;
            first = second;
            second = next;

            Console.Write(next + " ");
        }

        Console.WriteLine(); // for new line after printing the sequence
    }
    
    // params keyword
    static int SumNumbers(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}