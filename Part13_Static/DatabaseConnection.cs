namespace Part13_Static;

public class DatabaseConnection
{
    // lazy init
    // must control multi thread access, because it's not thread-safe
    private static DatabaseConnection? _instance = null;
    private static object _lock = new();

    public static DatabaseConnection GetInstance()
    {
        lock (_lock)
        {
            // automic
            if (_instance == null)
            {
                _instance = new DatabaseConnection();
                _instance.Connect();
            }
        }

        return _instance;
    }

    private void Connect()
    {
        throw new NotImplementedException();
    }
}