namespace FactoryMethod;

public abstract class SubscriptionCreator
{
    public abstract Subscription CreateDomesticSubscription();
    public abstract Subscription CreateEducationalSubscription();
    public abstract Subscription CreatePremiumSubscription();
    public abstract string GetCreatorType();
}