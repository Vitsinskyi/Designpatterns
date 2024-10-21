namespace Mediator;

internal class Program
{
    public static void Main(string[] args)
    {
        var runway1 = new Runway();
        var runway2 = new Runway();
        var aircraft1 = new Aircraft("A1");
        var aircraft2 = new Aircraft("A2");

        var commandCentre = new CommandCentre(new Runway[] { runway1, runway2 }, new Aircraft[] { aircraft1, aircraft2 });

        commandCentre.AssignRunway(aircraft1, runway1);
        commandCentre.AssignRunway(aircraft2, runway1);
        aircraft1.TakeOff(runway1);
        aircraft2.TakeOff(runway2);
    }
}