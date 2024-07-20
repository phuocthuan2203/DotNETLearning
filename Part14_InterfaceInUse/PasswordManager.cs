namespace Part14_InterfaceInUse;

public class UserManager : IPasswordAuthenticator, IUserStore
{
    public User? Authenticate(string username, string password)
    {
        throw new NotImplementedException();
    }

    public User? GetUser(string username)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(string username)
    {
        throw new NotImplementedException();
    }
}