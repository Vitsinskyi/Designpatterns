namespace Mediator;

class Aircraft
{
    public string Name;
    public Runway? CurrentRunway { get; set; }
    public bool IsTakingOff { get; set; }

    public Aircraft(string name)
    {
        Name = name;
    }

    public void Land(Runway runway)
    {
        Console.WriteLine($"Aircraft {Name} is landing.");
        Console.WriteLine("Checking runway.");
        if (runway.IsBusyWithAircraft == null)
        {
            Console.WriteLine($"Aircraft {Name} has landed.");
            runway.IsBusyWithAircraft = this;
            runway.HighLightRed();
            CurrentRunway = runway;
        }
        else
        {
            Console.WriteLine("Could not land, the runway is busy.");
        }
    }

    public void TakeOff(Runway runway)
    {
        Console.WriteLine($"Aircraft {Name} is taking off.");
        runway.IsBusyWithAircraft = null;
        CurrentRunway = null;
        runway.HighLightGreen();
        Console.WriteLine($"Aircraft {Name} has taken off.");
    }
}