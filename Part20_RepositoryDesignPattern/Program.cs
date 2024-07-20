using Part20_RepositoryDesignPattern.Data;
using Part20_RepositoryDesignPattern.Models;
using Part20_RepositoryDesignPattern.Services;

namespace Part20_RepositoryDesignPattern;

class Program
{
    static void Main()
    {
        string connectionString =
            "Server=localhost,1433;Database=CrudOperation;User Id=sa;Password=Thuan2203@;Encrypt=False;TrustServerCertificate=True;";

        IEmployeeRepository employeeRepository = new EmployeeRepository(connectionString);
        IEmployeeService employeeService = new EmployeeService(employeeRepository);

        // Perform CRUD operations
        employeeService.Add(new Employee { Name = "Alexander Nguyen", Position = "CEO", Salary = 160000 });
        DisplayEmployees(employeeService);
            
        employeeService.Update(new Employee { Id = 10, Name = "Nguyen Phuoc Thuan", Position = "Giam Doc FPT Software Quy Nhon", Salary = 170000 });
        DisplayEmployees(employeeService);
            
        employeeService.Delete(9);
        DisplayEmployees(employeeService);
    }

    static void DisplayEmployees(IEmployeeService employeeService)
    {
        var employees = employeeService.GetAll();
        Console.WriteLine("DisplayEmployees:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");
        }
    }
}