namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log("This is a log message");
            logger.Error("This is an error message");
            logger.Warn("This is a warning message");
            
            Logger loggerFile = new FileLogger();
            loggerFile.Log("This is a log message");
            loggerFile.Error("This is an error message");
            loggerFile.Warn("This is a warning message");
        }
    }
}