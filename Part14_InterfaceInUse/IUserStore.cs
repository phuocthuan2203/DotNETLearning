namespace Part14_InterfaceInUse;

public interface IUserStore
{
    User? GetUser(string username);
    void UpdateUser(User user);
    void DeleteUser(string username);
}