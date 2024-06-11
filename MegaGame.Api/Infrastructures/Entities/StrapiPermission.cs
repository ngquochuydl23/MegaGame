using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class StrapiPermission
{
    public int Id { get; set; }

    public string Action { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Properties { get; set; }

    public string? Conditions { get; set; }

    public int? Role { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
