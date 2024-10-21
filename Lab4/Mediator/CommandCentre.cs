namespace Mediator;

class CommandCentre
{
    private List<Runway> _runways = new List<Runway>();
    private List<Aircraft> _aircrafts = new List<Aircraft>();

    public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
    {
        _runways.AddRange(runways);
        _aircrafts.AddRange(aircrafts);
    }

    public void AssignRunway(Aircraft aircraft, Runway runway)
    {
        if (runway.IsBusyWithAircraft == null)
        {
            runway.IsBusyWithAircraft = aircraft;
            aircraft.CurrentRunway = runway;
            Console.WriteLine($"Aircraft {aircraft.Name} has been assigned to runway {runway.Id}.");
        }
        else
        {
            Console.WriteLine($"Could not assign runway to Aircraft {aircraft.Name}, the runway is busy.");
        }
    }
}
