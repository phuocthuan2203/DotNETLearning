// namespace Part9_LambdaExpression;
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         // expression lambda
//         var sum = (int a, int b) => a + b;
//         Func<int, int, int> sum1 = (int a, int b) => a - b;
//         Func<int, int, bool> compareTwoNum = (a, b) => a > b ? true : false;
//         Console.WriteLine(sum(1, 2));
//         Console.WriteLine(sum1(3, 4));
//         Console.WriteLine($"The result when comparing 1 and 2: {compareTwoNum(3, 2)}");
//         
//         // statement lambda
//         Action<string> printUpper = str => Console.WriteLine(str.ToUpper());
//         var printUpper2 = (string str) => Console.WriteLine(str.ToUpper());
//         Action<string, string> printLower = (string s1, string s2) => Console.WriteLine(s1.ToLower(), s2.ToUpper());
//         
//         printUpper("Process finished with exit code 0.");
//         printLower("LOWER", "upper");
//
//         var t = object (int a, int b) => a > b ? 0 : "A";
//         Console.WriteLine(t(1, 2));
//         Console.WriteLine(t(2, 1));
//         
//         // example 1
//         int A = 100;
//         int B = 200;
//         Call((a, b) => a + b, A, B);
//         Call((a, b) => a * b, A, B);
//         
//         // example 2
//         int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];
//         Print((x) => x > 5, arr);
//         
//         // sort an array ascendingly
//         int[] array = { 5, 3, 8, 1, 2 };
//         Console.WriteLine("\nAfter sorting:");
//         SortArray((x, y) => x < y, array);
//     }
//     
//     // example 1
//     static void Call(Func<int, int, int> f, int a, int b)
//     {
//         Console.WriteLine(f(a, b));
//     }
//     
//     // example 2
//     static void Print(Func<int, bool> f, int[] arr)
//     {
//         foreach (var i in arr)
//         {
//             if (f(i))
//             {
//                 Console.Write($"{i}  ");
//             }
//         }
//     }
//     
//     // sort an array ascendingly
//     static void SortArray(Func<int, int, bool> compareFunc, int[] array)
//     {
//         for (int i = 0; i < array.Length - 1; i++)
//         {
//             for (int j = i + 1; j < array.Length; j++)
//             {
//                 if (compareFunc(array[i], array[j]))
//                 {
//                     (array[i], array[j]) = (array[j], array[i]);
//                 }
//             }
//         }
//         Console.WriteLine(string.Join(", ", array));
//     }
// }