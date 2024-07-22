using Microsoft.Data.SqlClient;

namespace Part17_ADOdotNET;

public class Program
{
    static void Main(string[] args)
    {
        TestDbConnection();
    }

    public static void TestDbConnection()
    {
        const string connectionString = "Server=localhost,1433;Database=ADOdotNET;User Id=sa;Password=Thuan2203@;Encrypt=False;TrustServerCertificate=True;";

        // FIRST TESTING CONNECTION SUCCESSFULLY WAY
        // using var conn = new SqlConnection(connectionString);
        // conn.Open();
        // var cmd = conn.CreateCommand();
        // cmd.CommandText = "SELECT employee_id, email FROM employees";
        // using var reader = cmd.ExecuteReader();
        // {
        //     int count = 0;
        //     while (reader.Read())
        //     {
        //         Console.WriteLine($"ID: {reader.GetInt32(0)}, Email: {reader.GetString(1)}");
        //         ++count;
        //     }
        //
        //     Console.WriteLine($"The number of records from DB: {count}");
        // }
        //
        // reader.Close();
        // conn.Close();

        // SECOND TESTING CONNECTION SUCCESSFULLY WAY
        // using (SqlConnection connection = new SqlConnection(connectionString))
        // {
        //     try
        //     {
        //         connection.Open();
        //         Console.WriteLine("Connection to the database was successful!");
        //
        //         const string query = "SELECT employee_id, email FROM employees";
        //         using (SqlCommand command = new SqlCommand(query, connection))
        //         {
        //             using (SqlDataReader reader = command.ExecuteReader())
        //             {
        //                 while (reader.Read())
        //                 {
        //                     Console.WriteLine($"ID: {reader.GetInt32(0)}, Email: {reader.GetString(1)}");
        //                 }
        //             }
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine("An error occurred: " + ex.Message);
        //     }
        // }

        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();

        const string query = "SELECT * FROM jobs";
        SqlCommand command = new SqlCommand(query, connection);

        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            int count = 0;
            Console.WriteLine($"The {count} record: {reader}");
            ++count;
        }

        reader.Close();
        connection.Close();
    }
}