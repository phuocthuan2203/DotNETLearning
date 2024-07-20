using Microsoft.Data.SqlClient;

namespace Part18_CRUD_ADOdotNET;

public class BasicCRUDOperations
{
    static void Main(string[] args)
    {
        using var conn = DbConnect.GetConnection();

        CreateEmployee(conn, "Nguyen Phuoc Thuan", "Chief Executive Officer", 100000);
        CreateEmployee(conn, "Nguyen Van A", "Tester", 30000);
        CreateEmployee(conn, "Nguyen Van B", "Developer", 55000);
        CreateEmployee(conn, "Nguyen Van C", "Business Analyst", 11000);
        ReadEmployee(conn);
        // UpdateEmployee(conn, 2, "Thuan Nguyen Phuoc");
        // ReadEmployee(conn);
        // DeleteEmployee(conn, 3);
        // ReadEmployee(conn);
        
        DbConnect.CloseConnection();
    }

    private static void CreateEmployee(SqlConnection? conn, string name, string position, double salary)
    {
        try
        {
            const string insertQuery = "INSERT INTO Employees (Name, Position, Salary) VALUES (@Name, @Position, @Salary)";
            using SqlCommand command = new SqlCommand(insertQuery, conn);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Position", position);
            command.Parameters.AddWithValue("@Salary", salary);

            int result = command.ExecuteNonQuery();
            Console.WriteLine($"Rows affected: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void ReadEmployee(SqlConnection? conn)
    {
        const string selectQuery = "SELECT Id, Name, Position, Salary FROM Employees";

        using SqlCommand command = new SqlCommand(selectQuery, conn);
        using SqlDataReader reader = command.ExecuteReader();
        Console.WriteLine("Employee record: ");
        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Position: {reader["Position"]}, Salary: {reader["Salary"]}");
        }
    }

    private static void UpdateEmployee(SqlConnection? conn, int id, string name)
    {
        const string updateQuery = "UPDATE Employees SET Name = @Name WHERE Id = @Id";
        using SqlCommand command = new SqlCommand(updateQuery, conn);
        command.Parameters.AddWithValue("@Name", name);
        command.Parameters.AddWithValue("@Id", id);
        int result = command.ExecuteNonQuery();
        Console.WriteLine($"Row affected: {result}");
    }

    private static void DeleteEmployee(SqlConnection? conn, int id)
    {
        const string deleteQuery = "DELETE FROM Employees WHERE Id = @Id";
        using SqlCommand command = new SqlCommand(deleteQuery, conn);
        command.Parameters.AddWithValue("@Id", id);
        int result = command.ExecuteNonQuery();
        Console.WriteLine($"Row affected: {result}");
    }
}