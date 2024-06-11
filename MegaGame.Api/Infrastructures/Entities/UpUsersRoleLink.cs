using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class UpUsersRoleLink
{
    public int? UserId { get; set; }

    public int? RoleId { get; set; }
}
