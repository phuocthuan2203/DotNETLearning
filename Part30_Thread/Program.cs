namespace Part30_Thread;

class Program
{
    
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

        Thread countNumbers = new Thread(CountNumbers);
        Thread writeMessages = new Thread(WriteMessages);
        
        countNumbers.Start();
        writeMessages.Start();

        // waiting for 2 threads completed
        countNumbers.Join();
        writeMessages.Join();

        Console.WriteLine("Both threads have completed.");
    }

    private static void CountNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Counting: {i}");
            Thread.Sleep(1000);
        }
    }
    
    private static void WriteMessages()
    {
        string[] messages = { "Hello, World!", "Learning about threads.", "Threads can run concurrently.", "This is thread programming in .NET." };
        foreach (string message in messages)
        {
            Console.WriteLine($"Message: {message}");
            Thread.Sleep(1500); // Simulate work by sleeping for 1.5 seconds
        }
    }

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