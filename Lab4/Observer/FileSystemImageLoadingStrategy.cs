namespace Observer;

class FileSystemImageLoadingStrategy : IImageLoadingStrategy
{
    public void LoadImage(string href)
    {
        Console.WriteLine($"Loading image from file system: {href}");
    }
}