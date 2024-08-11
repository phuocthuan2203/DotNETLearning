namespace Part31_EventWaitHandle;

internal class Program
{
    private static readonly BlockingQueue<string> Queue = new();
    
    private static void Main(string[] args)
    {
        var dequeueThread = new Thread(DequeueThread) { IsBackground = true };
        dequeueThread.Start();
        dequeueThread = new Thread(DequeueThread) { IsBackground = true };
        dequeueThread.Start();
        
        string? str = null;
        do
        {
            Console.Write("S: ");
            str = Console.ReadLine();

            if (!string.IsNullOrEmpty(str))
            {
                Queue.EnQueue(str);
            }
        } while (!string.IsNullOrEmpty(str));
    }

    private static void DequeueThread()
    {
        while (true)
        {
            var s = Queue.DeQueue();
            Console.WriteLine($"Q = {s}");
        }
    }
}
