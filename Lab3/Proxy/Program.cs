namespace Proxy;

class Program
{
    static void Main(string[] args)
    {
        SmartTextReader reader = new SmartTextReader();
        SmartTextChecker checker = new SmartTextChecker(reader);
        SmartTextReaderLocker locker = new SmartTextReaderLocker(checker, @"\.cs$");

        locker.ReadFile("C:\\Users\\05naz\\DesignPatterns\\Lab3\\Proxy\\test.txt");
    }
}