namespace FactoryMethod;

public class DomesticSubscription : Subscription
{
    public override decimal MonthlyFee => 10.0m;
    public override int MinimumPeriod => 1;
    public override List<string> Channels => new List<string> { "Channel 1", "Channel 2" };
}