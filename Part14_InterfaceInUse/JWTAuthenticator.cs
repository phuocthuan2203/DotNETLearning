namespace Part14_InterfaceInUse;

public interface JWTAuthenticator
{
    User? Authenticate(string jwt);
}