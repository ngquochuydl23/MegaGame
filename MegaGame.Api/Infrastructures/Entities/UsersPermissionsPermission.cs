using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class UsersPermissionsPermission
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Controller { get; set; } = null!;

    public string Action { get; set; } = null!;

    public bool Enabled { get; set; }

    public string? Policy { get; set; }

    public int? Role { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }
}
