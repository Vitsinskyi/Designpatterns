namespace Proxy;

public class SmartTextChecker : SmartTextReader
{
    private SmartTextReader _reader;

    public SmartTextChecker(SmartTextReader reader)
    {
        this._reader = reader;
    }

    public override char[][] ReadFile(string filePath)
    {
        Console.WriteLine($"Opening file {filePath}");
        char[][] result = _reader.ReadFile(filePath);
        Console.WriteLine($"Successfully read file {filePath}");
        Console.WriteLine($"Lines: {result.Length}");
        int characters = 0;
        foreach (var line in result)
        {
            characters += line.Length;
        }
        Console.WriteLine($"Characters: {characters}");
        Console.WriteLine($"Closing file {filePath}");
        return result;
    }
}