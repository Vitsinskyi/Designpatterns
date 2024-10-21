namespace ChainOfResponsibilities;

class LevelOneSupportHandler : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Question == "Are you connected to the internet?")
        {
            if (request.Answer)
            {
                Console.WriteLine("Next question.");
            }
            else
            {
                Console.WriteLine("Please check your internet connection.");
            }
        }
        else
        {
            NextHandler?.HandleRequest(request);
        }
    }
}