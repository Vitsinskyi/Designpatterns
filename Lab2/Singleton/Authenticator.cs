namespace Singleton;

public sealed class Authenticator
{
    private static Authenticator? _instance = null;
    private static readonly object Lock = new object();

    Authenticator()
    {
    }

    public static Authenticator Instance
    {
        get
        {
            lock (Lock)
            {
                if (_instance == null)
                {
                    _instance = new Authenticator();
                }
                return _instance;
            }
        }
    }
}
