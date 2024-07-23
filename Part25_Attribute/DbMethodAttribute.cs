namespace Part25_Attribute;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class DbMethodAttribute : Attribute
{
    public DbMethodAttribute(string message)
    {
        
    }
}