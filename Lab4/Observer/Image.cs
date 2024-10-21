namespace Observer;

class Image
{
    private IImageLoadingStrategy _loadingStrategy;

    public Image(IImageLoadingStrategy loadingStrategy)
    {
        _loadingStrategy = loadingStrategy;
    }

    public void SetLoadingStrategy(IImageLoadingStrategy loadingStrategy)
    {
        _loadingStrategy = loadingStrategy;
    }

    public void Load(string href)
    {
        _loadingStrategy.LoadImage(href);
    }
}