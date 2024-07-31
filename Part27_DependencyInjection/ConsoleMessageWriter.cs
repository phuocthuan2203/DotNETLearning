namespace Part27_DependencyInjection;

public class ConsoleMessageWriter: IMessageWriter
{
    // private readonly INullInterface _nullInterface;
    //
    // public ConsoleMessageWriter(INullInterface nullInterface)
    // {
    //     _nullInterface = nullInterface;
    // }

    public ConsoleMessageWriter()
    {
        Console.WriteLine("New ConsoleMessageWriter");
    }
       
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}