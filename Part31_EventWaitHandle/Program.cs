namespace Part31_EventWaitHandle;

class Program
{
    private static int _counter = 0;
    private const int NumThreads = 10;
    private static AutoResetEvent _autoResetEvent = new AutoResetEvent(true);

    static void Main(string[] args)
    {
        Thread[] threads = new Thread[NumThreads];
        
        for (int i = 0; i < NumThreads; i++)
        {
            threads[i] = new Thread(IncrementCounter);
            threads[i].Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine($"Final value of counter: {_counter}");
    }
    
    private static void IncrementCounter()
    {
        for (int i = 0; i < 1000; i++)
        {
            _autoResetEvent.WaitOne();
            _counter++;
            _autoResetEvent.Set();
        }
    }
}