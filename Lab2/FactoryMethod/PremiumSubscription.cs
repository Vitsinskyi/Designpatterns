namespace FactoryMethod;

public class PremiumSubscription : Subscription
{
    public override decimal MonthlyFee => 20.0m;
    public override int MinimumPeriod => 1;
    public override List<string> Channels => new List<string> { "Premium Channel 1", "Premium Channel 2", "Premium Channel 3" };
}
