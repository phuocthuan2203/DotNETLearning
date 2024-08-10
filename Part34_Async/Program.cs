using System.Diagnostics;

namespace Part34_Async
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var t1 = Delay1Async();
            var t2 = Delay2Async();
            var t3 = Delay3Async();

            //await t1;
            //await t2;
            //await t3;
            //await t3;

            //Task.WaitAll(t1, t2, t3);

            //var tr = Task.Run(RunMethod);

            var t123 = Task.WhenAny(t1, t2, t3);
            await Task.WhenAny(t123);

            var t = CalculateResult(10);
            await t;

            stopwatch.Stop();
            Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");

        }

        static async Task Delay1Async()
        {
            Console.WriteLine("Delay1.....");
            await Task.Delay(1000);
            Console.WriteLine("Delay1 done.....");
        }

        static async Task Delay2Async()
        {
            Console.WriteLine("Delay2.....");
            await Task.Delay(2000);
            Console.WriteLine("Delay2 done.....");
        }

        static async Task Delay3Async()
        {
            Console.WriteLine("Delay3.....");
            await Task.Delay(3000);
            Console.WriteLine("Delay3 done.....");
        }

        static void RunMethod()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i = {i}");
                Task.Delay(500).Wait();
            }
        }

        static Task<double> CalculateResult(int n)
        {
            if(n == 0)
            {
                return Task.FromResult(0.0);
            }

            return Task.FromResult(Math.Pow(10, n));
        }
    }
}
