namespace FactoryMethod;

public class MobileApp : SubscriptionCreator
{
    public override Subscription CreateDomesticSubscription()
    {
        return new DomesticSubscription();
    }

    public override Subscription CreateEducationalSubscription()
    {
        return new EducationalSubscription();
    }

    public override Subscription CreatePremiumSubscription()
    {
        return new PremiumSubscription();
    }
    
    public override string GetCreatorType()
    {
        return "MobileApp";
    }
}