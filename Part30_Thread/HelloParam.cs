namespace Part30_Thread;

public class HelloParam
{
    public required string Name { get; set; }
    public int Delay { get; set; } = 1000;
    public CancellationToken CancellationToken { get; set; }
}