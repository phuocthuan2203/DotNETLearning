using System.Text;

namespace Part2_DataTypes;

class Program
{
    static void Main(string[] args)
    {
        // Chỉ cho phép sử dụng 1 biến khi nó đã được gán giá trị
        var a = true; // Boolean a = true;
        Console.WriteLine(a);

        Int32 c = 15;
        Double d = 1.2d;
        Single f = 1.3f;

        // string reference type
        string str = new string("Thuan");
        Console.WriteLine(str.ToUpper());
        
        // nullable
        int? n = null;
        if (n.HasValue) // n != null
        {
            Console.WriteLine("Has value");
        }
        else
        {
            Console.WriteLine("Not has value");
        }

        // interpolation string
        var s = $"Nguyen Phuoc Thuan {DateTime.Now} \\";
        Console.WriteLine(s); // Nguyen Phuoc Thuan 6/15/2024 6:52:56PM \
        
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("Nguyen Phuoc Thuan ");
        stringBuilder.Append($"{DateTime.Now}");
        stringBuilder.Append(" \\");
        Console.WriteLine(stringBuilder); // Nguyen Phuoc Thuan 6/15/2024 6:52:56PM \

        var firstNum = 1;
        Console.WriteLine(firstNum);

    }
}