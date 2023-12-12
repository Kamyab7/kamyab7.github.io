﻿using PersonalWebsite.Models;

namespace PersonalWebsite;

public static class AppConfigurationFactory
{
    public static AppConfiguration Create(IConfiguration config)
    {
        ArgumentNullException.ThrowIfNull(config);

        var aboutMe = config.GetSection(nameof(AppConfiguration.AboutMe)).Get<List<string>>();
        var social = config.GetSection(nameof(AppConfiguration.Social)).Get<Social>();
        var skills = config.GetSection(nameof(AppConfiguration.Skills)).Get<List<Skill>>();
        var experiences = config.GetSection(nameof(AppConfiguration.Experiences)).Get<List<Experience>>();
        var educations = config.GetSection(nameof(AppConfiguration.Educations)).Get<List<Education>>();

        var configuration = new AppConfiguration
        {
            Owner = config[nameof(AppConfiguration.Owner)],
            JobTitle = config[nameof(AppConfiguration.JobTitle)],
            EmailAddress = config[nameof(AppConfiguration.EmailAddress)],
            Birthday = config[nameof(AppConfiguration.Birthday)],
            Location = config[nameof(AppConfiguration.Location)],
            Phone = config[nameof(AppConfiguration.Phone)],
            AboutMe = aboutMe,
            Social = social,
            Skills = skills,
            Experiences = experiences,
            Educations = educations
        };

        return configuration;
    }
}
