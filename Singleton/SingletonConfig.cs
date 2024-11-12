namespace Singleton;

public class SingletonConfig
{
    private string Host { get; }
    private string Port { get; }
    private string Username { get; }
    private string Password { get; }

    private SingletonConfig(string host, string port, string username, string password)
    {
        Host = host;
        Port = port;
        Username = username;
        Password = password;
    }

    private static SingletonConfig _instance;

    public static SingletonConfig Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = readConfig();
            }
            return _instance;
        }
    }

    private static SingletonConfig readConfig()
    {
        return new SingletonConfig("host", "port", "admin", "admin");
    }
}