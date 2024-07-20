using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Part18_CRUD_ADOdotNET;

public class DbConnect
{
    private static SqlConnection? _conn = null;

    private static void InitConnection()
    {
        try
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);

            IConfiguration configuration = builder.Build(); // load the content in the .json file and build a IConfiguration object

            _conn = new SqlConnection(configuration.GetConnectionString("DatabaseConnection"));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public static SqlConnection? GetConnection()
    {
        if (_conn == null)
        {
            try
            {
                InitConnection();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        _conn?.Open();
        return _conn;
    }

    public static void CloseConnection()
    {
        _conn?.Close();;
    }
}