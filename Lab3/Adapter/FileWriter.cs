namespace Adapter;

public class FileWriter
{
    public void Write(string message)
    {
        File.WriteAllText("log.txt", message);
    }

    public void WriteLine(string message)
    {
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}