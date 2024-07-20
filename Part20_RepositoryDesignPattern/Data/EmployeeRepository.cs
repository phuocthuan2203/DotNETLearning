using Microsoft.Data.SqlClient;
using Part20_RepositoryDesignPattern.Models;

namespace Part20_RepositoryDesignPattern.Data;

public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Name, Position, Salary FROM Employees";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                Position = (string)reader["Position"],
                                Salary = (decimal)reader["Salary"]
                            });
                        }
                    }
                }
            }

            return employees;
        }

        public Employee GetById(int id)
        {
            Employee employee = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Name, Position, Salary FROM Employees WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                Position = (string)reader["Position"],
                                Salary = (decimal)reader["Salary"]
                            };
                        }
                    }
                }
            }

            return employee;
        }

        public void Add(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Employees (Name, Position, Salary) VALUES (@Name, @Position, @Salary)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@Position", employee.Position);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Employees SET Name = @Name, Position = @Position, Salary = @Salary WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", employee.Id);
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@Position", employee.Position);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Employees WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }