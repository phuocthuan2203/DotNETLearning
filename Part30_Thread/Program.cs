namespace Part30_Thread;

class Program
{
    private static int _counter = 0;
    private const int NumThreads = 10;
    private static readonly object LockObj = new object();

    static void Main(string[] args)
    {
        // var cts = new CancellationTokenSource();
        //
        // var thread1 = new Thread(new ParameterizedThreadStart(Print));
        // var thread2 = new Thread(new ParameterizedThreadStart(Print));
        // var thread3 = new Thread(new ParameterizedThreadStart(Print));
        // var thread4 = new Thread(new ParameterizedThreadStart(Print));
        //
        // thread1.Start(new HelloParam() {Name = "1", CancellationToken = cts.Token});
        // thread2.Start(new HelloParam() {Name = "2", Delay = 2000, CancellationToken = cts.Token});
        // thread3.Start(new HelloParam() {Name = "3", Delay = 3000, CancellationToken = cts.Token});
        // thread4.Start("T4");
        //
        // // Console.WriteLine();
        // // cts.Cancel();
        // cts.CancelAfter(10000);

        #region Thread demo
        // var thread1 = new Thread(PrintNumbers);
        // var thread2 = new Thread(PrintNumbers);
        //
        // thread1.Start();
        // thread2.Start();
        //
        // thread1.Join(); // Wait for thread1 to complete
        // thread2.Join(); // Wait for thread2 to complete
        // // thread1.IsBackground = true;
        // // thread2.IsBackground = true;
        //
        // Console.WriteLine("Main thread complete.");
        #endregion

        ExampleWithoutSynchronization();
    }

    static void PrintNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{Environment.CurrentManagedThreadId}: {i}");
            Thread.Sleep(100); // Simulate some work
        }
    }

    #region Example without Synchronization
    private static void ExampleWithoutSynchronization()
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

        Console.WriteLine($"Final counter value: {_counter}");
    }
    
    private static void IncrementCounter()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (LockObj)
            {
                _counter++;
            }
        }
    }
    #endregion

    private static void Print(object? p)
    {
        var hp = p as HelloParam;

        if (hp != null)
        {
            while (!hp.CancellationToken.IsCancellationRequested)
            {
                // hp?. -> only access the hp.Name when hp is not null
                // '?': null-conditional operator
                // '??': null-coalescing operator
                Console.WriteLine($"Hello {hp?.Name ?? "NAME"}");
            
                Thread.Sleep(hp?.Delay ?? 1000);
            }
        }
    }
}