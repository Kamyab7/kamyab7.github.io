namespace PersonalWebsite;

public static class AppConfigurationFactory
{
    public static AppConfiguration Create(IConfiguration config)
    {
        ArgumentNullException.ThrowIfNull(config);

        var aboutMe = config.GetSection(nameof(AppConfiguration.AboutMe)).Get<List<string>>();

        var configuration = new AppConfiguration
        {
            Owner = config[nameof(AppConfiguration.Owner)],
            JobTitle = config[nameof(AppConfiguration.JobTitle)],
            EmailAddress = config[nameof(AppConfiguration.EmailAddress)],
            Birthday = config[nameof(AppConfiguration.Birthday)],
            Location = config[nameof(AppConfiguration.Location)],
            Phone = config[nameof(AppConfiguration.Phone)],
            AboutMe = aboutMe,
        };

        return configuration;
    }
}
