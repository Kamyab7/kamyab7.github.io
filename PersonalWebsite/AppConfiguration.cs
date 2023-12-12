﻿using PersonalWebsite.Models;

namespace PersonalWebsite;

public sealed record AppConfiguration
{
    public string Owner { get; init; }

    public string JobTitle { get; init; }

    public string EmailAddress { get; init; }

    public string Birthday { get; init; }

    public string Location { get; set; }

    public string Phone { get; init; }

    public List<string> AboutMe { get; init; }

    public Social Social { get; init; }
}
