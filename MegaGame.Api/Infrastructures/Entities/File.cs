using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class File
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? AlternativeText { get; set; }

    public string? Caption { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string? Formats { get; set; }

    public string? Hash { get; set; }

    public string? Ext { get; set; }

    public string? Mime { get; set; }

    public decimal? Size { get; set; }

    public string? Url { get; set; }

    public string? PreviewUrl { get; set; }

    public string? Provider { get; set; }

    public string? ProviderMetadata { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedById { get; set; }

    public int? UpdatedById { get; set; }
}
