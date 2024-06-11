using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class AdminPermissionsRoleLink
{
    public int? PermissionId { get; set; }

    public int? RoleId { get; set; }
}
