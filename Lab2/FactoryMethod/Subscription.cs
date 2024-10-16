namespace FactoryMethod;

public abstract class Subscription
{
    public abstract decimal MonthlyFee { get; }
    public abstract int MinimumPeriod { get; }
    public abstract List<string> Channels { get; }
}