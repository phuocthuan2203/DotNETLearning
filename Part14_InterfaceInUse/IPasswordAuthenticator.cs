namespace Part14_InterfaceInUse;

public interface IPasswordAuthenticator
{
    User? Authenticate(string username, string password);

}