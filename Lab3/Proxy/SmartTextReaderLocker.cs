using System.Text.RegularExpressions;

namespace Proxy;

public class SmartTextReaderLocker : SmartTextReader
{
    private SmartTextReader _reader;
    private Regex _regex;

    public SmartTextReaderLocker(SmartTextReader reader, string pattern)
    {
        this._reader = reader;
        this._regex = new Regex(pattern);
    }

    public override char[][] ReadFile(string filePath)
    {
        if (_regex.IsMatch(filePath))
        {
            Console.WriteLine("Access denied!");
            return new char[0][];
        }
        else
        {
            return _reader.ReadFile(filePath);
        }
    }
}
