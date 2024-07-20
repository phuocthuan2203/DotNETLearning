namespace Part3_Array;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("One dimensional array: ");
        OneDimensionalArray();

        Console.WriteLine("Two dimensional array: ");
        TwoDimensionalArray();

        Console.WriteLine("Multi dimensional array: ");
        MultiDimensionalArray();

        Console.WriteLine("Jagged Array (Array in Array): ");
        JaggedArray();
    }

    static void OneDimensionalArray()
    {
        int[] array1 = new int[5] {2, 4, 6, 8, 10};

        int[] array2 = [1, 2, 3, 4, 5];

        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }
    }

    static void TwoDimensionalArray()
    {
        int[,] dimentionalArray = {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 }
        };
        Console.WriteLine(dimentionalArray[0, 4]);
    }

    static void MultiDimensionalArray()
    {
        // Hiểu nôm na: mảng 3 chiều có 2 phần tử, bên trong mỗi phần tử đó lại có 2 phần tử con, mỗi phần tử con chứa 10 phần tử con.
        // Số dòng và cột phải bằng nhau
        int[,,] multidimensionalArray =
        {
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 }
            },
            {
                { 11, 22, 33, 44, 55 },
                { 66, 77, 88, 99, 100 }
            }
        };
        Console.WriteLine(multidimensionalArray[1, 0, 2]); // output: 33
    }

    static void JaggedArray()
    {
        // 1 mảng 1 chiều chứa các phần tử, các phần tử lại là 1 Array
        int[][] mm = new int[4][];
        
        mm[0] = new int[4];
        mm[0][0] = 1;
        mm[0][1] = 2;
        mm[0][2] = 3;
        mm[0][3] = 4;
        
        mm[1] = new int[4];
        mm[1][0] = 5;
        mm[1][1] = 6;
        mm[1][2] = 7;
        mm[1][3] = 8;
        
        mm[2] = new int[4];
        mm[2][0] = 11;
        mm[2][1] = 22;
        mm[2][2] = 34;
        mm[2][3] = 46;
        
        mm[3] = new int[6];
        mm[3][0] = 10;
        mm[3][1] = 20;
        mm[3][2] = 30;
        mm[3][3] = 40;
        mm[3][4] = 50;
        mm[3][5] = 60;
        
        Console.WriteLine(mm[3][5]); // output: 60
    }
}