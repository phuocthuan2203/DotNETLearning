namespace ThreadPoolExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            // queue the tasks to the thread pool
            ThreadPool.QueueUserWorkItem(WorkMethod, "Task 1");
            ThreadPool.QueueUserWorkItem(WorkMethod, "Task 2");
            ThreadPool.QueueUserWorkItem(WorkMethod, "Task 3");

            Console.WriteLine("Main thread continues to execute.");

            // Keep the main thread alive to observe the background work
            Thread.Sleep(2000);

            Console.WriteLine("Main thread ending.");

        }

        static void WorkMethod(object state)
        {
            string? taskName = state as string;

            Console.WriteLine($"{taskName} started on thread ID {Environment.CurrentManagedThreadId}");

            // simulate some work
            Thread.Sleep(1000);

            Console.WriteLine($"{taskName} finished on thread ID {Environment.CurrentManagedThreadId}");

        }
    }
}
