namespace Part14_InterfaceSegregation;

class Program
{
    public static void Main()
    {
        // basic example about Interface Segregation
        IWork worker = new Worker(); 
        worker.Work();
        
        IEat eater = new Worker();
        eater.Eat();
        
        ISleep sleeper = new Worker();
        sleeper.Sleep();
        
        IWork robot = new Robot();
        robot.Work();
        
        // Smart home devices
        List<ISwitchable> switchableDevices = new List<ISwitchable>
        {
            new Light(),
            new SecurityCamera()
        };

        foreach (var device in switchableDevices)
        {
            device.TurnOn();
        }

        List<IAdjustable> adjustableDevices = new List<IAdjustable>
        {
            new Light(),
            new Thermostat()
        };

        foreach (var device in adjustableDevices)
        {
            device.SetLevel(5);
        }

        List<IRecordable> recordableDevices = new List<IRecordable>
        {
            new SecurityCamera()
        };

        foreach (var device in recordableDevices)
        {
            device.StartRecording();
        }
    }
}

public interface IWork
{
    void Work();
}

public interface IEat
{
    void Eat();
}

public interface ISleep
{
    void Sleep();
}

public class Worker : IWork, IEat, ISleep
{
    public void Work()
    {
        Console.WriteLine("Worker Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Worker Eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("Worker Sleeping...");
    }
}

public class Robot : IWork
{
    public void Work()
    {
        Console.WriteLine("Robot Working...");
    }
}