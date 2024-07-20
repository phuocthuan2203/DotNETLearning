namespace Part4_Conditional_Loop
{
    /// <summary>
    /// The main program class containing the entry point of the application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        static void Main(string[] args)
        {
            // conditional statements
            int x = 123;
            int y = 0;
        
            if (x == 0)
            {
                Console.WriteLine("x == 0");
            }
            else
            {
                Console.WriteLine("x != 0");
            }
        
            switch (x)
            {
                case 0:
                    Console.WriteLine("x == 0");
                    break;
                case 1:
                    Console.WriteLine("x == 0");
                    break;
                default:
                    Console.WriteLine($"x == {x}");
                    break;
            }
            
            // loop statement
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello, World!");
            }
        
            int index = 4;
            while (index > 0)
            {
                Console.WriteLine("Hello, World!");
                index--;
            }
        
            do
            {
                Console.WriteLine("Hello world neeee");
            } while (1 < 0);
        
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        
            var list = new List<string>();
            foreach (string arg in args)
            {
                list.Add(arg.ToUpper());
            }
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
            
            // ASSIGNMENT
            Assignment.FindPosition();

            Console.WriteLine("Selection sort:");
            Assignment.SelectionSort();
            Console.WriteLine();
            
            Console.WriteLine("Interchange sort:");
            Assignment.InterchangeSort();
            Console.WriteLine();

            Console.WriteLine("Bubble Sort:");
            Assignment.BubbleSort();
            Console.WriteLine();

            Console.WriteLine("Insertion Sort:");
            Assignment.InsertionSort();
            Console.WriteLine();

            Assignment.PrintEachCharacter("Nguyen Phuoc Thuan");
        }
    }

    /// <summary>
    /// Contains assignment methods for finding positions and sorting arrays.
    /// </summary>
    static class Assignment
    {
        /// <summary>
        /// Finds the position of a user-specified number in a randomly generated array.
        /// </summary>
        public static void FindPosition()
        {
            // enter a number and return the position of this number in the array
            var rand = new Random();
            
            var arr = new int[10];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next() % 1000;
            }
    
            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
    
            Console.WriteLine("Enter a number: ");
            var number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] != number) continue;
                Console.WriteLine($"The {number} is at the position {i} in the array");
                return;
            }
    
            Console.WriteLine($"can't find the {number} in the array");
        }

        /// <summary>
        /// Sorts a randomly generated array using selection sort algorithm.
        /// </summary>
        public static void SelectionSort()
        {
            var rand = new Random();
            
            var arr = new int[10];
            for (var k = 0; k < arr.Length; k++)
            {
                arr[k] = rand.Next() % 1000;
            }
            
            foreach (var x in arr)
            {
                Console.Write($"{x}\t");
            }

            // Selection Sort
            for (var i = 0; i < arr.Length - 1; i++)
            {
                var minIndex = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }

            Console.WriteLine();
            foreach (var x in arr)
            {
                Console.Write($"{x}\t");
            }
        }

        /// <summary>
        /// Sorts a randomly generated array using interchange sort algorithm.
        /// </summary>
        public static void InterchangeSort()
        {
            var rand = new Random();
            
            var arr = new int[10];
            for (var k = 0; k < arr.Length; k++)
            {
                arr[k] = rand.Next() % 1000;
            }
            
            foreach (var x in arr)
            {
                Console.Write($"{x}\t");
            }
            
            // after the arrangement
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = arr.Length - 1; j > i; j--)
                {
                    if (arr[i] > arr[j])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
            }            
            
            Console.WriteLine();
            foreach (var x in arr)
            {
                Console.Write($"{x}\t");
            }
        }

        /// <summary>
        /// Sorts a randomly generated array using bubble sort algorithm.
        /// </summary>
        public static void BubbleSort()
        {
            var rand = new Random();
            
            var arr = new int[10];
            for (var k = 0; k < arr.Length; k++)
            {
                arr[k] = rand.Next() % 1000;
            }
            
            foreach (var x in arr)
            {
                Console.Write($"{x}\t");
            }

            // Bubble Sort
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }

            Console.WriteLine();
            foreach (var x in arr)
            {
                Console.Write($"{x}\t");
            }
        }

        /// <summary>
        /// Sorts a randomly generated array using insertion sort algorithm.
        /// </summary>
        public static void InsertionSort()
        {
            var rand = new Random();
            
            var arr = new int[10];
            for (var k = 0; k < arr.Length; k++)
            {
                arr[k] = rand.Next() % 1000;
            }
            
            foreach (var x in arr)
            {
                Console.Write($"{x}\t");
            }

            // Insertion Sort
            for (var i = 1; i < arr.Length; i++)
            {
                var key = arr[i];
                var j = i - 1;
                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            Console.WriteLine();
            foreach (var x in arr)
            {
                Console.Write($"{x}\t");
            }
        }

        /// <summary>
        /// Prints each character of the specified string.
        /// </summary>
        /// <param name="str">The string to print each character of.</param>
        public static void PrintEachCharacter(string str)
        {
            Console.WriteLine($"Each character in '{str}' is:");
            for (var i = 0; i < str.Length; i++)
            {
                Console.Write($"{str[i]} ");
            }
        }
    }
}
