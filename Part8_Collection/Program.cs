using System.Collections;
using System.Collections.Immutable;

namespace Part8_Collection;

class Program
{
    static void Main(string[] args)
    {
        var list = new List<String>();
        
        ReadStrings(list);
        Print(list);
        Sort(list);
        Console.WriteLine("After sorting:");
        Print(list);
        
        Console.WriteLine("Indexable Collection: ");
        IndexableCollection();
        
        // non-generic collection
        var arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("two");
        
        // generic collection
        var intList = new List<int>();
        intList.Add(1);
        intList.Add(2);

        // key-value pairs collection
        var dictionary = new Dictionary<int, string>();
        dictionary[1] = "one";
        dictionary[2] = "two";
        
        // first in, first out collection
        var queue = new Queue<string>();
        queue.Enqueue("first");
        queue.Enqueue("second");
        
        // last in, first out collection
        var stack = new Stack<string>();
        stack.Push("first");
        stack.Push("second");
        
        // immutable collection
        var immutableList = ImmutableList.Create(1, 2, 3);
     
        foreach (var i in immutableList)
        {
            Console.WriteLine(i);
        }
    }

    private static void IndexableCollection()
    {
        List<int> numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        
        for (var index = numbers.Count - 1; index >= 0; index--)
        {
            if (numbers[index] % 2 == 1)
            {
                numbers.RemoveAt(index);
            }
        }
        
        numbers.ForEach(number => Console.Write(number + " "));
    }

    private static void Sort(List<string> list)
    {
        for (var i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (String.Compare(list[i], list[j], StringComparison.Ordinal) > 0)
                {
                    (list[i], list[j]) = (list[j], list[i]);
                }
            }
        }
    }

    private static void Print(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    private static void ReadStrings(List<string> list)
    {
        string? str;
        do
        {
            str = Console.ReadLine();

            if (!string.IsNullOrEmpty(str))
            {
                list.Add(str);
            }
        } while (!string.IsNullOrEmpty(str));
    }
}