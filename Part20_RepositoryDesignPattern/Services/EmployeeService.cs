using Part20_RepositoryDesignPattern.Data;
using Part20_RepositoryDesignPattern.Models;

namespace Part20_RepositoryDesignPattern.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    // create an IEmployeeRepository inside the EmployeeService class
    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public IEnumerable<Employee> GetAll()
    {
        return _employeeRepository.GetAll();
    }

    public Employee GetById(int id)
    {
        return _employeeRepository.GetById(id);
    }

    public void Add(Employee employee)
    {
        _employeeRepository.Add(employee);
    }

    public void Update(Employee employee)
    {
        _employeeRepository.Update(employee);
    }

    public void Delete(int id)
    {
        _employeeRepository.Delete(id);
    }
}