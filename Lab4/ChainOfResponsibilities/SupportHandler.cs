namespace ChainOfResponsibilities;

abstract class SupportHandler
{
    protected SupportHandler NextHandler;

    public void SetNextHandler(SupportHandler handler)
    {
        NextHandler = handler;
    }

    public abstract void HandleRequest(SupportRequest request);
}