namespace Observer;

class NetworkImageLoadingStrategy : IImageLoadingStrategy
{
    public void LoadImage(string href)
    {
        Console.WriteLine($"Loading image from network: {href}");
    }
}
