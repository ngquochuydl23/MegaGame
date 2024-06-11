using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class UploadFile
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? AlternativeText { get; set; }

    public string? Caption { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string? Formats { get; set; }

    public string Hash { get; set; } = null!;

    public string? Ext { get; set; }

    public string Mime { get; set; } = null!;

    public decimal Size { get; set; }

    public string Url { get; set; } = null!;

    public string? PreviewUrl { get; set; }

    public string Provider { get; set; } = null!;

    public string? ProviderMetadata { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
