using Part20_RepositoryDesignPattern.Models;

namespace Part20_RepositoryDesignPattern.Data;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAll();
    Employee GetById(int id);
    void Add(Employee employee);
    void Update(Employee employee);
    void Delete(int id);
}