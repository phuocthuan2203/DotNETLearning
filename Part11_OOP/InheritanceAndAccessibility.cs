namespace Part11_OOP;

public class A
{
    private readonly int _value = 10;
    protected readonly int SecondValue = 20;
    internal readonly int ThirdValue = 30;
    public readonly int FourthValue = 40;

    public class AccessPrivateInside : A
    {
        public int GetValue()
        {
            return _value;
        }
    }
}

public class AccessPrivateOutside : A
{
    // public int GetValue()
    // {
    //     return _value; // _value is NOT accessible here, this will cause a compilation error
    // }
}

public class AccessProtected : A
{
    public int GetValue()
    {
        return SecondValue;
    }
}

public class AccessInternal : A
{
    public int GetValue()
    {
        return ThirdValue;
    }
}

public class AccessPublic : A
{
    public int GetValue()
    {
        return FourthValue;
    }
}