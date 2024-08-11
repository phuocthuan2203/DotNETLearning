namespace Part33_CriticalSection;

class Program
{
    private static int _firstNum = 10;
    private static int _secondNum = 20;
    private static readonly object LockObject = new object();
    
    static void Main(string[] args)
    {
        var thread = new Thread(new ThreadStart(P)) {IsBackground = true};
        thread.Start();
        
        Print();
        Swap();
        Print();
    }

    private static void Swap()
    {
        lock (LockObject)
        {
            #region Critical Section

            int temp = _firstNum;
            Thread.Sleep(100);
            _firstNum = _secondNum;
            Thread.Sleep(200);
            _secondNum = temp;

            #endregion
        }
    }

    private static void Print()
    {
        lock (LockObject)
        {
            Console.WriteLine($"x = {_firstNum}, y = {_secondNum}");
        }
    }

    private static void P()
    {
        while (true)
        {
            Print();
            Thread.Sleep(30);
        }
    }
}