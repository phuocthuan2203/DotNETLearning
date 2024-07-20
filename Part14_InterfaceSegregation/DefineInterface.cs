namespace Part14_InterfaceSegregation;

public interface ISwitchable
{
    void TurnOn();
    void TurnOff();
}

public interface IAdjustable
{
    void SetLevel(int level);
}

public interface IRecordable
{
    void StartRecording();
    void StopRecording();
}
