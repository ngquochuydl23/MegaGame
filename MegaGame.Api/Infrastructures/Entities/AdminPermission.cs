using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class AdminPermission
{
    public int Id { get; set; }

    public string? Action { get; set; }

    public string? Subject { get; set; }

    public string? Properties { get; set; }

    public string? Conditions { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedById { get; set; }

    public int? UpdatedById { get; set; }
}
