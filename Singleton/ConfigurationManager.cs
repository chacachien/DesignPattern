namespace Singleton;

public class ConfigurationManager
{
    /// <summary>
    /// The Lazy<T> type ensures that the ConfigurationManager instance is created in a lazy and thread-safe manner.
    /// This means the instance is only created when it is first accessed and is safe to use across multiple threads.
    /// </summary>
    private static Lazy<ConfigurationManager> _instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());

    /// <summary>
    /// The constructor is private to prevent instantiation from outside the class.
    /// This ensures that the only way to get an instance of ConfigurationManager is through the Instance property.
    /// </summary>
    private ConfigurationManager()
    {
        SetSetting("AppName", "Noname");
    }
    
    private readonly Dictionary<string, string> _setting = new();
    public static ConfigurationManager Instance => _instance.Value;

    public string? GetSetting(string key)
    {
        string? result; 
        _setting.TryGetValue(key, out result);
        return result;
    }

    public void SetSetting(string key, string value)
    {
        _setting[key] = value;
    }
}