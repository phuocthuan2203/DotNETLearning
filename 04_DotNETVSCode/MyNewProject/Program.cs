using System;
using System.Threading.Tasks;

public class Program {
    public async Task DoWorkAsync() {
        System.Console.WriteLine("Work started...");
        await Task.Delay(3000);
        System.Console.WriteLine("Work completed.");
    }

    public static async Task Main(string[] args) {
        var program = new Program();
        await program.DoWorkAsync();
        System.Console.WriteLine("Main method completed.");
    }
}