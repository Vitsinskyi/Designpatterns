namespace FactoryMethod;

public class EducationalSubscription : Subscription
{
    public override decimal MonthlyFee => 5.0m;
    public override int MinimumPeriod => 6;
    public override List<string> Channels => new List<string> { "Educational Channel 1", "Educational Channel 2" };
}