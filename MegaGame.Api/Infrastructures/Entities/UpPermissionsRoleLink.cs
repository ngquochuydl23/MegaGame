using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class UpPermissionsRoleLink
{
    public int? PermissionId { get; set; }

    public int? RoleId { get; set; }
}
