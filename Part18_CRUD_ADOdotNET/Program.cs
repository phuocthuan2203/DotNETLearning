using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Part18_CRUD_ADOdotNET;

class Program
{
    // static void Main(string[] args)
    // {
    //     // ListCountries(DbConnect.GetConnection());
    //     // DisplayNumberOfCountries(DbConnect.GetConnection());
    //     using var conn = DbConnect.GetConnection();
    //     using var trans = conn?.BeginTransaction();
    //     
    //     // CreateEmployee("Nguyen", "TRANS 3", "nguyenthuan@gmail.com", "0123456789", DateTime.Today, 9, 10000, 100, 6, _conn, trans);
    //     // CreateEmployee("Nguyen", "TRANS 4", "nguyenthuan@gmail.com", "0123456789", DateTime.Today, 9, 10000, 100, 6, _conn, trans);
    //     // UpdateJob("President TRANS", 22222, 33333, 4, conn, trans);
    //     // UpdateJob("Accountant TRANS", 44444, 55555, 6, conn, trans);
    //     DisplayNumberOfCountries(conn, trans);
    //     
    //     trans?.Commit();
    //     // trans.Rollback(); // nothing change because 2 insert commands have been rollbacked
    //     
    //     conn?.Close();
    // }

    private static void DisplayNumberOfCountries(SqlConnection? conn, SqlTransaction? trans)
    {
        try
        {
            var cmd = new SqlCommand("SELECT COUNT(*) FROM countries", conn, trans);
            int c = (int)cmd.ExecuteScalar();

            Console.WriteLine($"Total: {c} rows");
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            DbConnect.CloseConnection();
        }
    }

    private static void ListCountries(SqlConnection? conn)
    {
        try
        {
            var cmd = new SqlCommand("SELECT * FROM countries", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader[0]}, Name: {reader[1]}");
            }

            reader.Close();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            DbConnect.CloseConnection();
        }
    }

    private static int CreateEmployee(
        string firstName, string lastName, string email, string phoneNumber, 
        DateTime hireDate, int jobId, double salary, int managerId, int departmentId, SqlConnection? conn, SqlTransaction? trans)
    {
        var cmd = new SqlCommand(@"INSERT INTO employees(
                                    first_name,
                                    last_name,
                                    email,
                                    phone_number,
                                    hire_date,
                                    job_id,
                                    salary,
                                    manager_id,
                                    department_id 
                                ) VALUES (
                                    @first_name,
                                    @last_name,
                                    @email,
                                    @phone_number,
                                    @hire_date,
                                    @job_id,
                                    @salary,
                                    @manager_id,
                                    @department_id
                                )", conn, trans);

        cmd.Parameters.Add(new SqlParameter("@first_name", System.Data.SqlDbType.VarChar, 20)).Value = firstName;
        cmd.Parameters.Add(new SqlParameter("@last_name", System.Data.SqlDbType.VarChar, 25)).Value = lastName;
        cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 100)).Value = email;
        cmd.Parameters.Add(new SqlParameter("@phone_number", System.Data.SqlDbType.VarChar, 20)).Value = phoneNumber;
        cmd.Parameters.Add(new SqlParameter("@hire_date", System.Data.SqlDbType.DateTime)).Value = hireDate;
        cmd.Parameters.Add(new SqlParameter("@job_id", System.Data.SqlDbType.Int)).Value = jobId;
        cmd.Parameters.Add(new SqlParameter("@salary", System.Data.SqlDbType.Decimal)).Value = salary;
        cmd.Parameters.Add(new SqlParameter("@manager_id", System.Data.SqlDbType.Int)).Value = managerId;
        cmd.Parameters.Add(new SqlParameter("@department_id", System.Data.SqlDbType.Int)).Value = departmentId;

        return cmd.ExecuteNonQuery();
    }

    private static int UpdateJob(string jobTitle, double minSalary, double maxSalary, int jobId, SqlConnection? conn, SqlTransaction? trans)
    {
        var cmd = new SqlCommand(@"UPDATE jobs 
            SET job_title = @job_title, min_salary = @min_salary, max_salary = @max_salary 
            WHERE job_id = @job_id", 
            conn, trans);

        cmd.Parameters.Add(new SqlParameter("@job_title", System.Data.SqlDbType.VarChar, 35)).Value = jobTitle;
        cmd.Parameters.Add(new SqlParameter("@min_salary", System.Data.SqlDbType.Decimal)).Value = minSalary;
        cmd.Parameters.Add(new SqlParameter("@max_salary", System.Data.SqlDbType.Decimal)).Value = maxSalary;
        cmd.Parameters.Add(new SqlParameter("@job_id", System.Data.SqlDbType.Int)).Value = jobId;

        return cmd.ExecuteNonQuery();
    }
}