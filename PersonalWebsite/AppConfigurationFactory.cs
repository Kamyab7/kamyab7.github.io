namespace PersonalWebsite;

public static class AppConfigurationFactory
{
    public static AppConfiguration Create(IConfiguration config)
    {
        ArgumentNullException.ThrowIfNull(config);

        var configuration = new AppConfiguration
        {
            Owner = config[nameof(AppConfiguration.Owner)],
        };

        return configuration;
    }
}
