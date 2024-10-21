namespace ChainOfResponsibilities;

class LevelThreeSupportHandler : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Question == "Have you restarted your device?")
        {
            if (request.Answer)
            {
                Console.WriteLine("Next question.");
            }
            else
            {
                Console.WriteLine("Please restart your device.");
            }
        }
        else
        {
            NextHandler?.HandleRequest(request);
        }
    }
}
