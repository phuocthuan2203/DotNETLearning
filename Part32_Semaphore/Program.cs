namespace Part32_Semaphore;

class Program
{
    private static readonly Random Random = new();
    private static int _itemInBox = 0;
    private const int Max = 10;
    private static Semaphore _semaphore = new (Max, Max);
    private static AutoResetEvent _fullEvent = new(false);
    
    static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            var thread = new Thread(new ParameterizedThreadStart(MoveItemThread))
            {
                IsBackground = true
            };
            thread.Start(i.ToString());
        }

        var tt = new Thread(ReplaceBox)
        {
            IsBackground = true
        };
        tt.Start();

        Console.ReadLine();
    }

    // hàm đại diện cho thread chuyển sản phẩm từ băng chuyền vào hộp
    private static void MoveItemThread(object? o)
    {
        var armNumber = o?.ToString() ?? "-";

        while (true)
        {
            _semaphore.WaitOne();
            
            Console.WriteLine($"{armNumber} - Moving item...");
            
            Thread.Sleep(Random.Next(100, 400));

            MoveItem();
            
            Thread.Sleep(Random.Next(1000, 4000));
            
            Console.WriteLine($"{armNumber} - Done");
        }
    }

    private static void MoveItem()
    {
        _itemInBox++;
        Console.WriteLine($"Current quantity: {_itemInBox}");
        if (_itemInBox == Max)
        {
            _fullEvent.Set();
        }
    }

    private static void ReplaceBox()
    {
        while (true)
        {
            // 1 thread dùng nhiều CPU nhưng chỉ để kiểm tra câu if -> tạo AutoResetEvent, mỗi khi Move() mà full thì sẽ set event đó lên
            // if (_itemInBox == Max)
            // {
            //     Console.WriteLine("Replace with a new box");
            //     _itemInBox = 0;
            //     _semaphore.Release(Max);
            // }

            _fullEvent.WaitOne();
            Console.WriteLine("Replace with a new box");
            _itemInBox = 0;
            _semaphore.Release(Max);
        }
    }
}