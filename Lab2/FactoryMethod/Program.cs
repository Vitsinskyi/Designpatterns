using System.Text;

namespace FactoryMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SubscriptionCreator creator = new WebSite();
            Subscription domesticSubscription = creator.CreateDomesticSubscription();

            StringBuilder sb = new StringBuilder();
            sb.Append("Created ")
                .Append(domesticSubscription.GetType().Name)
                .Append(" with monthly fee ")
                .Append(domesticSubscription.MonthlyFee)
                .Append(" and minimum period ")
                .Append(domesticSubscription.MinimumPeriod)
                .Append(" via ")
                .Append(creator.GetCreatorType())
                .AppendLine();
            
            creator = new MobileApp();
            Subscription educationalSubscription = creator.CreateEducationalSubscription();

            sb.Append("Created ")
                .Append(educationalSubscription.GetType().Name)
                .Append(" with monthly fee ")
                .Append(educationalSubscription.MonthlyFee)
                .Append(" and minimum period ")
                .Append(educationalSubscription.MinimumPeriod)
                .Append(" via ")
                .Append(creator.GetCreatorType())
                .AppendLine();
            
            creator = new ManagerCall();
            Subscription premiumSubscription = creator.CreatePremiumSubscription();

            sb.Append("Created ")
                .Append(premiumSubscription.GetType().Name)
                .Append(" with monthly fee ")
                .Append(premiumSubscription.MonthlyFee)
                .Append(" and minimum period ")
                .Append(premiumSubscription.MinimumPeriod)
                .Append(" via ")
                .Append(creator.GetCreatorType());

            Console.WriteLine(sb.ToString());
        }
    }
}