namespace Part13_Static;

internal class AccessCounter
{
    private int counter = 0;
    
    private static readonly AccessCounter accessCounter = new();

    public int Counter { get; }

    public int Inc()
    {
        counter++;
        return counter;
    }

    public static AccessCounter GetInstance()
    {
        return accessCounter;
    }
}