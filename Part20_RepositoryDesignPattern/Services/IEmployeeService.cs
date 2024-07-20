using Part20_RepositoryDesignPattern.Models;

namespace Part20_RepositoryDesignPattern.Services;

public interface IEmployeeService
{
    IEnumerable<Employee> GetAll();
    Employee GetById(int id);
    void Add(Employee employee);
    void Update(Employee employee);
    void Delete(int id);
}