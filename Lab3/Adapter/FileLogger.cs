namespace Adapter;

public class FileLogger : Logger
{
    private FileWriter _fileWriter = new FileWriter();

    public override void Log(string message)
    {
        _fileWriter.Write(message);
        Console.WriteLine("Massage added to file");
    }

    public override void Error(string message)
    {
        _fileWriter.Write(message);
        Console.WriteLine("Massage added to file");
    }

    public override void Warn(string message)
    {
        _fileWriter.Write(message);
        Console.WriteLine("Massage added to file");
    }
}