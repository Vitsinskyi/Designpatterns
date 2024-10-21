namespace Mediator;

class Runway
{
    public readonly Guid Id = Guid.NewGuid();
    public Aircraft? IsBusyWithAircraft;

    public bool CheckIsActive()
    {
        return IsBusyWithAircraft != null && IsBusyWithAircraft.IsTakingOff;
    }

    public void HighLightRed()
    {
        Console.WriteLine($"Runway {Id} is busy!");
    }

    public void HighLightGreen()
    {
        Console.WriteLine($"Runway {Id} is free!");
    }
}