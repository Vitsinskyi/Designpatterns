namespace ChainOfResponsibilities;

class LevelFourSupportHandler : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Question == "Is the issue related to a hardware problem?")
        {
            if (request.Answer)
            {
                Console.WriteLine("Please contact technical support for hardware assistance.");
            }
            else
            {
                Console.WriteLine("Please contact support to give us more information.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, we couldn't resolve your issue.");
        }
    }
}