namespace Part9_LambdaExpression;

public class ReLearn
{
    static void Main(string[] args)
    {
        // expression lambda
        var sum = (int a, int b) => a + b;
        // explicitly indicate the type of parameter's list and result
        Func<int, int, string> sum1 = (a, b) => (a + b).ToString();
        Console.WriteLine(sum1(1, 2));
        
        // statement lambda
        Action<string, string> printUpper = (firstName, lastName) =>
            Console.WriteLine($"First name: {firstName}, last name: {lastName}");
        printUpper("Thuan", "Nguyen");
        
        // use object type if the returned result are not the same type
        var t = object (int a, int b) => a > b ? 0 : "A";
        Console.WriteLine(t(1, 2));
        Console.WriteLine(t(2, 1));
        
        // usage of lambda expression
        Console.WriteLine("usage of lambda expression:");
        int A = 100, B = 200;
        Call((a, b) => a + b, A, B);
        Call((a, b) => a * b, A, B);

        int[] arr = [-200, -100, 100, 200, 300, 400, 500];
        Call_2(a => a > 200, arr);
        Call_2(a => a <= 200, arr);
    }

    static void Call(Func<int, int, int> f, int a, int b)
    {
        Console.WriteLine(f(a, b));
    }

    static void Call_2(Func<int, bool> f, int[] arr)
    {
        foreach(var i in arr)
        {
            // instead of using a condition like i > 100,
            // we use lambda expression to freely adding the custom condition we want in the function call
            if (f(i))
            {
                Console.Write($"{i}  ");
            }
        }
        Console.WriteLine();
    }
}