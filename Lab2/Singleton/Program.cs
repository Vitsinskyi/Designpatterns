namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        Authenticator auth1 = Authenticator.Instance;
        Authenticator auth2 = Authenticator.Instance;

        if (auth1 == auth2)
        {
            Console.WriteLine("Authenticator is singleton");
        }
        else
        {
            Console.WriteLine("Authenticator is not singleton");
        }
    }
}