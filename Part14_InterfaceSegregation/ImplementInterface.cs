namespace Part14_InterfaceSegregation;

public class Light : ISwitchable, IAdjustable
{
    public void TurnOn()
    {
        Console.WriteLine("Light is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is turned off.");
    }

    public void SetLevel(int level)
    {
        Console.WriteLine($"Light brightness set to {level}.");
    }
}

public class Thermostat : IAdjustable
{
    public void SetLevel(int level)
    {
        Console.WriteLine($"Thermostat temperature set to {level} degrees.");
    }
}

public class SecurityCamera : ISwitchable, IRecordable
{
    public void TurnOn()
    {
        Console.WriteLine("Security camera is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Security camera is turned off.");
    }

    public void StartRecording()
    {
        Console.WriteLine("Security camera started recording.");
    }

    public void StopRecording()
    {
        Console.WriteLine("Security camera stopped recording.");
    }
}
