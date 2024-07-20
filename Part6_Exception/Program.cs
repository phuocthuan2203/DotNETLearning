namespace Part6_Exception;

class Program
{
    static void Main(string[] args)
    {
        // try
        // {
        //     try
        //     {
        //         Console.Write("Nhap n: ");
        //         int n = int.Parse(Console.ReadLine());
        //         int x = 10 / n;
        //
        //         Console.WriteLine(x);
        //
        //         // Exception sẽ nhảy vào catch với type tương ứng, nếu không thì nó sẽ nhảy vào catch(Exception)
        //         // throw new ArithmeticException("Nguyen Phuoc Thuan");
        //     }
        //     catch (DivideByZeroException ex)
        //     {
        //         Console.WriteLine($"Loi chia cho khong: {ex.Message}");
        //         // throw new ArithmeticException("Nguyen Phuoc Thuan");
        //         throw;
        //     }
        //     catch (FormatException ex)
        //     {
        //         Console.WriteLine("Loi dinh dang");
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine(ex.ToString());
        //     }
        //     finally
        //     {
        //         Console.WriteLine("FINALLY");
        //     }
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.ToString());
        // }

        MethodZ();
    }
    
    static void MethodZ()
    {
        MethodA();
    }

    static void MethodA()
    {
        MethodB();
    }

    static void MethodB()
    {
        MethodC();
    }

    static void MethodC()
    {
        throw new InvalidOperationException("An error occurred in MethodC.");
    }
}