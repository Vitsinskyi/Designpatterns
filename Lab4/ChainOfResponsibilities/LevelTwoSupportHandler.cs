namespace ChainOfResponsibilities;

class LevelTwoSupportHandler : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Question == "Is your device charged?")
        {
            if (request.Answer)
            {
                Console.WriteLine("Next question.");
            }
            else
            {
                Console.WriteLine("Please charge your device.");
            }
        }
        else
        {
            NextHandler?.HandleRequest(request);
        }
    }
}